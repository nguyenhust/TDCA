//-----------------------------------------------------------------------
// <copyright file="IReadOnlyBindingList.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>no summary</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csla.Core
{
  internal interface IReadOnlyBindingList
  {
    bool IsReadOnly { get; set; }
  }
}