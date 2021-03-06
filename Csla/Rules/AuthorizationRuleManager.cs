//-----------------------------------------------------------------------
// <copyright file="AuthorizationRuleManager.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>Manages the list of authorization </summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Csla.Reflection;

namespace Csla.Rules
{
  /// <summary>
  /// Manages the list of authorization 
  /// rules for a business type.
  /// </summary>
  public class AuthorizationRuleManager
  {
#if !SILVERLIGHT
    private static Lazy<System.Collections.Concurrent.ConcurrentDictionary<RuleSetKey, AuthorizationRuleManager>> _perTypeRules =
      new Lazy<System.Collections.Concurrent.ConcurrentDictionary<RuleSetKey, AuthorizationRuleManager>>();

    internal static AuthorizationRuleManager GetRulesForType(Type type, string ruleSet)
    {
      if (ruleSet == ApplicationContext.DefaultRuleSet) ruleSet = null;

      var key = new RuleSetKey { Type = type, RuleSet = ruleSet };
      var result = _perTypeRules.Value.GetOrAdd(key, (t) => { return new AuthorizationRuleManager(); });
      InitializePerTypeRules(result, type);
      return result;
    }
#else
    private static Dictionary<RuleSetKey, AuthorizationRuleManager> _perTypeRules = new Dictionary<RuleSetKey, AuthorizationRuleManager>();

    internal static AuthorizationRuleManager GetRulesForType(Type type, string ruleSet)
    {
      // use null if RuleSet is "default" 
      if (ruleSet == ApplicationContext.DefaultRuleSet) ruleSet = null;

      AuthorizationRuleManager result = null;
      var key = new RuleSetKey { Type = type, RuleSet = ruleSet };
      var found = false;
      try
      {
        found = _perTypeRules.TryGetValue(key, out result);
      }
      catch
      { /* failure will drop into !found block */ }
      if (!found)
      {
        lock (_perTypeRules)
        {
          if (!_perTypeRules.TryGetValue(key, out result))
          {
            result = new AuthorizationRuleManager();
            _perTypeRules.Add(key, result);
          }
        }
      }
      InitializePerTypeRules(result, type);
      return result;
    }
#endif

    internal static AuthorizationRuleManager GetRulesForType(Type type)
    {
      return GetRulesForType(type, null);
    }

    private static void InitializePerTypeRules(AuthorizationRuleManager mgr, Type type)
    {
      if (!mgr.InitializedPerType)
        lock (mgr)
          if (!mgr.InitializedPerType)
          {
            mgr.InitializedPerType = true;

            // Only call AddObjectAuthorizationRules when there are no rules for this type
            if (RulesExistForType(type)) return;
            try
            {
              // invoke method to add auth roles
              var flags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly;
              System.Reflection.MethodInfo method = type.GetMethod("AddObjectAuthorizationRules", flags);
              if (method != null)
                method.Invoke(null, null);
            }
            catch (Exception)
            {
              // remove all loaded rules for this type
              CleanupRulesForType(type);
              throw;  // and rethrow the exception
            }
          }
    }

    private static bool RulesExistForType(Type type)
    {
      lock (_perTypeRules)
      {
        // the first RuleSet is already added to list when this check is executed so so if count > 1 then we have already initialized type rules.
#if !SILVERLIGHT
        return _perTypeRules.Value.Count(value => value.Key.Type == type) > 1;
#else

        return (_perTypeRules.Count(value => value.Key.Type == type)) > 1;
#endif
      }

    }

    private static void CleanupRulesForType(Type type)
    {
      lock (_perTypeRules)
      {

        // the first RuleSet is already added to list when this check is executed so so if count > 1 then we have already initialized type rules.
#if !SILVERLIGHT
        var typeRules = _perTypeRules.Value.Where(value => value.Key.Type == type);
        foreach (var key in typeRules)
        {
          AuthorizationRuleManager manager;
          _perTypeRules.Value.TryRemove(key.Key, out manager);
        }
#else
        var typeRules = _perTypeRules.Where(value => value.Key.Type == type).ToArray();
        foreach (var key in typeRules)
        {
          _perTypeRules.Remove(key.Key);
        }
#endif
      }
    }

    private class RuleSetKey
    {
      public Type Type { get; set; }
      public string RuleSet { get; set; }

      public override bool Equals(object obj)
      {
        var other = obj as RuleSetKey;
        if (other == null)
          return false;
        else
          return this.Type.Equals(other.Type) && RuleSet == other.RuleSet;
      }

      public override int GetHashCode()
      {
        return (this.Type.FullName + RuleSet).GetHashCode();
      }
    }

    /// <summary>
    /// Gets the list of rule objects for the business type.
    /// </summary>
    public List<IAuthorizationRule> Rules { get; private set; }

    /// <summary>
    /// Gets or sets a value indicating whether the rules have been
    /// initialized.
    /// </summary>
    public bool Initialized { get; internal set; }
    /// <summary>
    /// Gets or sets a value indicating whether the rules have been
    /// initialized.
    /// </summary>
    public bool InitializedPerType { get; internal set; }

    private AuthorizationRuleManager()
    {
      Rules = new List<IAuthorizationRule>();
    }
  }
}