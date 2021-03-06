using System;
using System.Collections.Generic;
using System.IO;
using Csla.Properties;

namespace Csla.Serialization.Mobile
{
	/// <summary>
	/// This is a class that is responsible for deserializing SerializationInfo objects for
	/// receiving the data from client / server
	/// </summary>
	public class CslaBinaryReader : ICslaReader
	{

		private readonly Dictionary<int, string> keywordsDictionary;

		/// <summary>
		/// Creates new instance of CslaBinaryReader
		/// </summary>
		public CslaBinaryReader()
		{
			keywordsDictionary = new Dictionary<int, string>();
		}

		/// <summary>
		/// Read a data from a stream, typically MemoryStream, and convert it into 
		/// a list of SerializationInfo objects
		/// </summary>
		/// <param name="serializationStream">Stream to read the data from</param>
		/// <returns>List of SerializationInfo objects</returns>
		public List<SerializationInfo> Read(Stream serializationStream)
		{
			var returnValue = new List<SerializationInfo>();
			int childCount, valueCount, referenceId;
			string systemName, enumTypeName;
			bool isDirty;
			object value;
			keywordsDictionary.Clear();
			using (var reader = new BinaryReader(serializationStream))
			{
				int totalCount = reader.ReadInt32();
				for (int counter = 0; counter < totalCount; counter++)
				{
					var info = new SerializationInfo();
					info.ReferenceId = reader.ReadInt32();
					info.TypeName = (string)ReadObject(reader);

					childCount = reader.ReadInt32();
					for (int childCounter = 0; childCounter < childCount; childCounter++)
					{
						systemName = (string)ReadObject(reader);
						isDirty = (bool)ReadObject(reader);
						referenceId = (int)ReadObject(reader);
						info.AddChild(systemName, referenceId, isDirty);
					}

					valueCount = reader.ReadInt32();
					for (int valueCounter = 0; valueCounter < valueCount; valueCounter++)
					{
						systemName = (string)ReadObject(reader);
						enumTypeName = (string)ReadObject(reader);
						isDirty = (bool)ReadObject(reader);
						value = ReadObject(reader);
						info.AddValue(systemName, value, isDirty, string.IsNullOrEmpty(enumTypeName) ? null : enumTypeName);
					}
					returnValue.Add(info);
				}
			}

			return returnValue;
		}

		private object ReadObject(BinaryReader reader)
		{
			var knownType = (CslaKnownTypes)reader.ReadByte();
			switch (knownType)
			{
				case CslaKnownTypes.Boolean:
					return reader.ReadBoolean();
				case CslaKnownTypes.Char:
					return reader.ReadChar();
				case CslaKnownTypes.SByte:
					return reader.ReadSByte();
				case CslaKnownTypes.Byte:
					return reader.ReadByte();
				case CslaKnownTypes.Int16:
					return reader.ReadInt16();
				case CslaKnownTypes.UInt16:
					return reader.ReadUInt16();
				case CslaKnownTypes.Int32:
					return reader.ReadInt32();
				case CslaKnownTypes.UInt32:
					return reader.ReadUInt32();
				case CslaKnownTypes.Int64:
					return reader.ReadInt64();
				case CslaKnownTypes.UInt64:
					return reader.ReadUInt64();
				case CslaKnownTypes.Single:
					return reader.ReadSingle();
				case CslaKnownTypes.Double:
					return reader.ReadDouble();
				case CslaKnownTypes.Decimal:
					int totalBits = reader.ReadInt32();
					int[] decimalBits = new int[totalBits];
					for (int counter = 0; counter < totalBits; counter++)
					{
						decimalBits[counter] = reader.ReadInt32();
					}
					return new Decimal(decimalBits);
				case CslaKnownTypes.DateTime:
					return new DateTime(reader.ReadInt64());
				case CslaKnownTypes.String:
					return reader.ReadString();
				case CslaKnownTypes.TimeSpan:
					return new TimeSpan(reader.ReadInt64());
				case CslaKnownTypes.DateTimeOffset:
					return new DateTimeOffset(reader.ReadInt64(), new TimeSpan(reader.ReadInt64()));
				case CslaKnownTypes.Guid:
					return new Guid(reader.ReadBytes(16));  // 16 bytes in a Guid
				case CslaKnownTypes.ByteArray:
					return reader.ReadBytes(reader.ReadInt32());
				case CslaKnownTypes.CharArray:
					return reader.ReadChars(reader.ReadInt32());
				case CslaKnownTypes.ListOfInt:
					var returnValue = new List<int>();
					int total = reader.ReadInt32();
					for (int counter = 0; counter < total; counter++)
					{
						returnValue.Add(reader.ReadInt32());
					}
					return returnValue;
				case CslaKnownTypes.Null:
					return null;
				case CslaKnownTypes.StringWithDictionaryKey:
					string systemString = reader.ReadString();
					keywordsDictionary.Add(reader.ReadInt32(), systemString);
					return systemString;
				case CslaKnownTypes.StringDictionaryKey:
					return keywordsDictionary[reader.ReadInt32()];
				default:
					throw new ArgumentOutOfRangeException(Resources.UnandledKNownTypeException);
			}
		}

	}
}
