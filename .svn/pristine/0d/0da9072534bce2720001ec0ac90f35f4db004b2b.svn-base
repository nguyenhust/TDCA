
//-----------------------------------------------------------------------
// <copyright file="TransactionManager.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>Provides an automated way to reuse open</summary>
//-----------------------------------------------------------------------
using System;
using System.Configuration;
using System.Data;
using Csla.Properties;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using System.Data.SqlClient;

namespace Csla.Data
{
  /// <summary>
  /// Provides an automated way to reuse open
  /// database connections and associated
  /// ADO.NET transactions within the context
  /// of a single data portal operation.
  /// </summary>
  /// <typeparam name="C">
  /// Type of database connection object to use.
  /// </typeparam>
  /// <typeparam name="T">
  /// Type of ADO.NET transaction object to use.
  /// </typeparam>
  /// <remarks>
  /// This type stores the open ADO.NET transaction
  /// in <see cref="Csla.ApplicationContext.LocalContext" />
  /// and uses reference counting through
  /// <see cref="IDisposable" /> to keep the transaction
  /// open for reuse by child objects, and to automatically
  /// dispose the transaction when the last consumer
  /// has called Dispose."
  /// </remarks>
  /// 


    public class MySecurity
    {
        /// <summary>
        /// Kiểm tra xem có thông với máy có địa chỉ IP được truyền vài hay không
        /// </summary>
        /// <param name="strDiaChiIP">Địa chỉ IP của máy cần kiểm tra</param>
        /// <returns></returns>
        public static bool IsCoThongVoiMay(string strDiaChiIP)
        {
            // cho nay them vao de chay voi may cai instance khong de default
            //string MyServerName = strDiaChiIP.Substring(0, 3);
            //strDiaChiIP = MyServerName;
            //end
            if (strDiaChiIP.Contains(@".\"))
                return true;
            IPAddress ip = (IPAddress)Dns.GetHostEntry(strDiaChiIP.Equals(".") ? "127.0.0.1" : strDiaChiIP).AddressList[0];
            PingOptions options = new PingOptions(128, true);
            Ping ping = new Ping();
            byte[] data = new byte[32];
            List<long> responseTimes = new List<long>();
            PingReply reply = ping.Send(ip, 1000, data, options);
            if (reply != null)
            {
                switch (reply.Status)
                {
                    case IPStatus.Success:
                        return true;
                    case IPStatus.TimedOut:
                        return false;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }

        ////public const string SECURITYKEY = "";
        //public const string SECURITYKEY = "tto@uty123";
        public const string SECURITYKEY = "@1980đội";
        /// <summary>
        /// Encrypt a string using dual encryption method. Return a encrypted cipher Text
        /// </summary>
        /// <param name="toEncrypt">string to be encrypted</param>
        /// <param name="useHashing">use hashing? send to for extra secirity</param>
        /// <returns></returns>
        /// 
        #region Bỏ đi vì lý do bảo mật
        //public static string Encrypt(string toEncrypt, bool useHashing)
        //{

        //    byte[] keyArray;
        //    byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
        //    //System.Windows.Forms.MessageBox.Show(key);
        //    if (useHashing)
        //    {
        //        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(SECURITYKEY));
        //        hashmd5.Clear();
        //    }
        //    else
        //        keyArray = UTF8Encoding.UTF8.GetBytes(SECURITYKEY);

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //    tdes.Key = keyArray;
        //    tdes.Mode = CipherMode.ECB;
        //    tdes.Padding = PaddingMode.PKCS7;

        //    ICryptoTransform cTransform = tdes.CreateEncryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        //    tdes.Clear();
        //    return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        //}
        #endregion
        //public static string Encrypt(string toEncrypt, bool useHashing)
        //{
        //    byte[] keyArray;
        //    byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
        //    //System.Windows.Forms.MessageBox.Show(key);
        //    if (useHashing)
        //    {
        //        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(SECURITYKEY));
        //        hashmd5.Clear();
        //    }
        //    else
        //        keyArray = UTF8Encoding.UTF8.GetBytes(SECURITYKEY);

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //    tdes.Key = keyArray;
        //    tdes.Mode = CipherMode.ECB;
        //    tdes.Padding = PaddingMode.PKCS7;

        //    ICryptoTransform cTransform = tdes.CreateEncryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        //    tdes.Clear();
        //    return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        //}
        /// <summary>
        /// DeCrypt a string using dual encryption method. Return a DeCrypted clear string
        /// </summary>
        /// <param name="cipherString">encrypted string</param>
        /// <param name="useHashing">Did you use hashing to encrypt this data? pass true is yes</param>
        /// <returns></returns>
        public static string Decrypt(string cipherString, bool useHashing)
        {
            try
            {
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(cipherString);

                if (useHashing)
                {
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(SECURITYKEY));
                    hashmd5.Clear();
                }
                else
                    keyArray = UTF8Encoding.UTF8.GetBytes(SECURITYKEY);

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                tdes.Clear();
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }

  public class TransactionManager<C, T> : IDisposable
    where C : IDbConnection, new()
    where T : IDbTransaction
  {
    private static object _lock = new object();
    private C _connection;
    private T _transaction;
    private string _connectionString;
    private string _label;

    /// <summary>
    /// Gets the TransactionManager object for the 
    /// specified database.
    /// </summary>
    /// <param name="database">
    /// Database name as shown in the config file.
    /// </param>
    public static TransactionManager<C, T> GetManager(string database)
    {
      return GetManager(database, true);
    }

    /// <summary>
    /// Gets the TransactionManager object for the 
    /// specified database.
    /// </summary>
    /// <param name="database">
    /// Database name as shown in the config file.
    /// </param>
    /// <param name="label">Label for this transaction.</param>
    public static TransactionManager<C, T> GetManager(string database, string label)
    {
      return GetManager(database, true, label);
    }

    /// <summary>
    /// Gets the TransactionManager object for the 
    /// specified database.
    /// </summary>
    /// <param name="database">
    /// The database name or connection string.
    /// </param>
    /// <param name="isDatabaseName">
    /// True to indicate that the Transaction string
    /// should be retrieved from the config file. If
    /// False, the database parameter is directly 
    /// used as a Transaction string.
    /// </param>
    /// <returns>TransactionManager object for the name.</returns>
    public static TransactionManager<C, T> GetManager(string database, bool isDatabaseName)
    {
      return GetManager(database, isDatabaseName, "default");
    }

    /// <summary>
    /// Gets the TransactionManager object for the 
    /// specified database.
    /// </summary>
    /// <param name="database">
    /// The database name or connection string.
    /// </param>
    /// <param name="isDatabaseName">
    /// True to indicate that the Transaction string
    /// should be retrieved from the config file. If
    /// False, the database parameter is directly 
    /// used as a Transaction string.
    /// </param>
    /// <param name="label">Label for this transaction.</param>
    /// <returns>TransactionManager object for the name.</returns>
    public static TransactionManager<C, T> GetManager(string database, bool isDatabaseName, string label)
    {
        try
        {
            var conn = "";

            conn = ConfigurationManager.ConnectionStrings[database].ConnectionString;
            database = MySecurity.Decrypt(conn, true);

            if (isDatabaseName)
            {
                if (database == null)
                    throw new ConfigurationErrorsException(String.Format(Resources.DatabaseNameNotFound, database));

                if (string.IsNullOrEmpty(database))
                    throw new ConfigurationErrorsException(String.Format(Resources.DatabaseNameNotFound, database));
            }

            //SqlConnection cn = new SqlConnection(database);
            //if (!MySecurity.IsCoThongVoiMay(cn.DataSource))
            //{
            //    throw new Exception("Lỗi kết nối đến máy chủ(Không ping tới được máy chủ)");
            //}

            lock (_lock)
            {
                var contextLabel = GetContextName(database, label);
                TransactionManager<C, T> mgr = null;
                if (ApplicationContext.LocalContext.Contains(contextLabel))
                {
                    mgr = (TransactionManager<C, T>)(ApplicationContext.LocalContext[contextLabel]);

                }
                else
                {
                    mgr = new TransactionManager<C, T>(database, label);
                    ApplicationContext.LocalContext[contextLabel] = mgr;
                }
                mgr.AddRef();
                return mgr;
            }
        }
        catch
        {
            throw new Exception("Không thể kết nối tới máy chủ(TimeOut). !");
        }
    }

    private TransactionManager(string connectionString, string label)
    {
      _label = label;
      _connectionString = connectionString;

      // create and open connection
      _connection = new C();
      _connection.ConnectionString = connectionString;
      _connection.Open();
      //start transaction
      _transaction = (T)_connection.BeginTransaction();

    }

    private static string GetContextName(string connectionString, string label)
    {
      return "__transaction:" + label + "-" + connectionString;
    }

    /// <summary>
    /// Gets a reference to the current ADO.NET
    /// transaction object.
    /// </summary>
    public T Transaction
    {
      get
      {
        return _transaction;
      }
    }

    /// <summary>
    /// Gets a reference to the current ADO.NET
    /// connection object that is associated with 
    /// current trasnaction.
    /// </summary>
    public C Connection
    {
      get
      {
        return _connection;
      }
    }

    private bool _commit = false;

    /// <summary>
    /// Indicates that the current transactional
    /// scope has completed successfully. If all
    /// transactional scopes complete successfully
    /// the transaction will commit when the
    /// TransactionManager object is disposed.
    /// </summary>
    public void Commit()
    {
      if (RefCount == 1)
        _commit = true;
    }

    #region  Reference counting

    private int _refCount;

    /// <summary>
    /// Gets the current reference count for this
    /// object.
    /// </summary>
    public int RefCount
    {
      get { return _refCount; }
    }

    private void AddRef()
    {
      _refCount += 1;
    }

    private void DeRef()
    {
      lock (_lock)
      {
        _refCount -= 1;
        if (_refCount == 0)
        {
          try
          {
            if (_commit)
              _transaction.Commit();
            else
              _transaction.Rollback();
          }
          finally
          {
            _transaction.Dispose();
            _connection.Dispose();
            ApplicationContext.LocalContext.Remove(GetContextName(_connectionString, _label));
          }
        }
      }

    }

    #endregion

    #region  IDisposable

    /// <summary>
    /// Dispose object, dereferencing or
    /// disposing the connection it is
    /// managing.
    /// </summary>
    public void Dispose()
    {
      DeRef();
    }

    #endregion
  }
}