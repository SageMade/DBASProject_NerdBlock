using System;
using System.Collections.Generic;
using System.Reflection;

namespace NerdBlock.Engine.Backend
{
    /// <summary>
    /// The main data access class for the entire backed
    /// </summary>
    public static class DataAccess
    {
        private static Dictionary<Type, object> myDataAccessors;
        private static IDatabase myDatabase;

        /// <summary>
        /// Gets or sets the Database connection to handle data access with
        /// </summary>
        public static IDatabase Database
        {
            get { return myDatabase; }
            set { myDatabase = value; }
        }

        /// <summary>
        /// Static contstructor for the DataAccess
        /// </summary>
        static DataAccess()
        {
            // Create the internal dictionaries
            myDataAccessors = new Dictionary<Type, object>();
        }

        #region Query Execution

        /// <summary>
        /// Executes a sql query or statement with parameters
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <param name="qParams">The query parameters for the query</param>
        /// <param name="parameters">The parameter values for the query</param>
        /// <returns>The results of executing the query or statement</returns>
        public static IQueryResult Execute(string query, QueryParam[] qParams, object[] parameters)
        {
            // Create the query and execute it with the database instance
            IQuery dbQuery = Database.PrepareQuery(query, qParams);
            return Database.Execute(dbQuery, parameters);
        }

        /// <summary>
        /// Executes a parameterless sql query or statement
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <returns>The results of executing the query or statement</returns>
        public static IQueryResult Execute(string query)
        {
            // Create the query and execute it with the database instance
            IQuery dbQuery = Database.PrepareQuery(query);
            return Database.Execute(dbQuery);
        }

        /// <summary>
        /// Executes a sql statement with parameters and returns the number of modified rows
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <param name="qParams">The query parameters for the query</param>
        /// <param name="parameters">The parameter values for the query</param>
        /// <returns>The number of rows modified by the statement</returns>
        public static int ExecuteStatement(string query, QueryParam[] qParams, params object[] parameters)
        {
            // Create the query and execute it with the database instance
            IQuery dbQuery = Database.PrepareQuery(query, qParams);
            IQueryResult result = Database.Execute(dbQuery, parameters);

            // Return the number of modified rows
            return result.NumRows;
        }

        #endregion

        #region Strong Model Data Access

        /// <summary>
        /// Gets the ModelDataAccess for a given model type
        /// </summary>
        /// <typeparam name="T">The type of model to get the DA for</typeparam>
        /// <returns>The dataaccess instance for the given model type</returns>
        private static ModelDataAccess<T> __GetDataAccess<T>() where T : new()
        {
            // If we don't have one, make it and store it in dictionary
            if (!myDataAccessors.ContainsKey(typeof(T)))
                myDataAccessors.Add(typeof(T), new ModelDataAccess<T>());

            // Get the value from the dictionary
            return myDataAccessors[typeof(T)] as ModelDataAccess<T>;
        }

        /// <summary>
        /// Updates a model in the database
        /// </summary>
        /// <typeparam name="T">The type of the model to update</typeparam>
        /// <param name="value">The model to update</param>
        /// <param name="updateNullValues">True if null values in the model should be set to null in the database</param>
        /// <param name="updateChildren">True if child models should be updated from model instance</param>
        /// <returns>The number of rows modified</returns>
        public static int Update<T>(T value, bool updateNullValues = true, bool updateChildren = true) where T : new()
        {
            return __GetDataAccess<T>().Update(value, updateNullValues, updateChildren);
        }

        /// <summary>
        /// Deletes a model from the database. The model should be a model loaded from the database
        /// </summary>
        /// <typeparam name="T">The type of the model to delete</typeparam>
        /// <param name="model">The model instance to update</param>
        /// <param name="deleteChildren">True if child models should be deleted</param>
        /// <returns>The number of rows deleted</returns>
        public static int Delete<T>(T model, bool deleteChildren = false) where T : new()
        {
            return __GetDataAccess<T>().Delete(model, deleteChildren);
        }

        /// <summary>
        /// Gets all models from the database that match the given value. Null fields in the search term
        /// will be ignored
        /// </summary>
        /// <typeparam name="T">The type of the model to match</typeparam>
        /// <param name="match">The item to match for</param>
        /// <returns>The collection of models loaded from the database</returns>
        public static T[] Match<T>(T match) where T : new()
        {
            return __GetDataAccess<T>().GetMatches(match);
        }

        /// <summary>
        /// Gets whether a given model exists in the database. Primary key value will be ignored,
        /// as well as (optionally) null fields
        /// </summary>
        /// <typeparam name="T">The type of the model to check</typeparam>
        /// <param name="match">The item to match for</param>
        /// <param name="matchNull">True if null values should be null in the database, false if they should be ignored</param>
        /// <returns>True if the item exists, false if otherwise</returns>
        public static bool Exists<T>(T match, bool matchNull = false) where T : new()
        {
            return __GetDataAccess<T>().Exists(match, matchNull);
        }

        /// <summary>
        /// Gets whether a given model exists in the database. Primary key value will be ignored,
        /// as well as (optionally) null fields
        /// </summary>
        /// <typeparam name="T">The type of the model to check</typeparam>
        /// <param name="match">The item to match for</param>
        /// <returns>True if the item was added, false if otherwise</returns>
        public static bool Insert<T>(T model) where T : new()
        {
            return __GetDataAccess<T>().Insert(model);
        }

        /// <summary>
        /// Gets all models from the database wil the given model type
        /// </summary>
        /// <typeparam name="ValueType">The value type for the model</typeparam>
        /// <returns>The collection of models fetched from the database</returns>
        public static ValueType[] SelectAll<ValueType>() where ValueType : new()
        {
            return __GetDataAccess<ValueType>().SelectAll();
        }

        /// <summary>
        /// Gets the first primary key value for the given model
        /// </summary>
        /// <typeparam name="T">The type of the model to operate on</typeparam>
        /// <param name="value">The value to get the primary key for</param>
        /// <returns>The models's primary key</returns>
        public static object GetPrimaryKey<T>(T value) where T : new()
        {
            return __GetDataAccess<T>().GetPrimaryKey(value);
        }

        /// <summary>
        /// Gets the model from the database with the given primary key
        /// </summary>
        /// <typeparam name="T">The type of the model to operate on</typeparam>
        /// <param name="value">The value of the primary key</param>
        /// <returns>The model instance with the given model ID</returns>
        public static T FromPrimaryKey<T>(object value) where T : new()
        {
            return __GetDataAccess<T>().GetFromPrimaryKey(value);
        }

        #endregion

        #region Weak Model Data Access

        /// <summary>
        /// Updates a model in the database, using the weak typing system. This code is much less safe than Update&lt;T&gt;, and
        /// should be avoided at all costs
        /// </summary>
        /// <param name="modelType">The type of the model to update</param>
        /// <param name="value">The model to update</param>
        /// <param name="updateNullValues">True if null values in the model should be set to null in the database</param>
        /// <param name="updateChildren">True if child models should be updated from model instance</param>
        /// <returns>The number of rows modified</returns>
        public static int UpdateWeak(Type modelType, object value, bool updateNullValues = true, bool updateChildren = true)
        {
            // Use reflection to invoke the generic method
            MethodInfo mi = typeof(DataAccess).GetMethod("Update", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return (int)mi.Invoke(null, new object[] { value, updateNullValues, updateChildren });
        }

        /// <summary>
        /// Deletes a model from the database. The model should be a model loaded from the database. This code is much less safe than Delete&lt;T&gt;, and
        /// should be avoided at all costs
        /// </summary>
        /// <param name="modelType">The type of the model to delete</param>
        /// <param name="model">The model instance to delete</param>
        /// <param name="deleteChildren">True if child models should be deleted</param>
        /// <returns>The number of rows deleted</returns>
        public static int DeleteWeak(Type modelType, object model, bool deleteChildren = false)
        {
            // Use reflection to invoke the generic method
            MethodInfo mi = typeof(DataAccess).GetMethod("Delete", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return (int)mi.Invoke(null, new object[] { model, deleteChildren });
        }

        /// <summary>
        /// Gets all models from the database that match the given value. Null fields in the search term
        /// will be ignored. This code is much less safe than Match&lt;T&gt;, and should be avoided at 
        /// all costs
        /// </summary>
        /// <param name="modelType">The type of the model to match</param>
        /// <param name="match">The item to match for</param>
        /// <returns>The collection of models loaded from the database</returns>
        public static object[] MatchWeak(Type modelType, object match)
        {
            // Use reflection to invoke the generic method
            MethodInfo mi = typeof(DataAccess).GetMethod("Match", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return (object[])mi.Invoke(null, new object[] { match });
        }

        /// <summary>
        /// Gets whether a given model exists in the database. Primary key value will be ignored,
        /// as well as (optionally) null fields. This code is much less safe than Exists&lt;T&gt;, and should 
        /// be avoided at all costs
        /// </summary>
        /// <param name="modelType">The type of the model to match</param>
        /// <param name="match">The item to match for</param>
        /// <param name="matchNull">True if null values should be null in the database, false if they should be ignored</param>
        /// <returns>True if the item exists, false if otherwise</returns>
        public static bool ExistsWeak(Type modelType, object match, bool matchNull = false)
        {
            // Use reflection to invoke the generic method
            MethodInfo mi = typeof(DataAccess).GetMethod("Exists", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return (bool)mi.Invoke(null, new object[] { match, matchNull });
        }

        /// <summary>
        /// Gets whether a given model exists in the database. Primary key value will be ignored,
        /// as well as (optionally) null fields. This code is much less safe than Insert&lt;T&gt;, and should 
        /// be avoided at all costs
        /// </summary>
        /// <param name="modelType">The type of the model to match</param>
        /// <param name="match">The item to match for</param>
        /// <returns>True if the item was added, false if otherwise</returns>
        public static bool InsertWeak(Type modelType, object model)
        {
            // Use reflection to invoke the generic method
            MethodInfo mi = typeof(DataAccess).GetMethod("Insert", BindingFlags.Static | BindingFlags.Public);
            mi = mi.MakeGenericMethod(modelType);
            return (bool)mi.Invoke(null, new[] { model });
        }

        /// <summary>
        /// Gets the first primary key value for the given model. This code is much less safe than GetPrimaryKey&lt;T&gt;, and should 
        /// be avoided at all costs
        /// </summary>
        /// <param name="modelType">The type of the model to match</param>
        /// <param name="value">The value to get the primary key for</param>
        /// <returns>The models's primary key</returns>
        public static object GetPrimaryKeyWeak(Type modelType, object value)
        {
            // Use reflection to invoke the generic method
            MethodInfo mi = typeof(DataAccess).GetMethod("GetPrimaryKey", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return mi.Invoke(null, new object[] { value });
        }

        /// <summary>
        /// Gets the model from the database with the given primary key. This code is much less safe than FromPrimaryKey&lt;T&gt;, and should 
        /// be avoided at all costs
        /// </summary>
        /// <param name="modelType">The type of the model to match</param>
        /// <param name="value">The value of the primary key</param>
        /// <returns>The model instance with the given model ID</returns>
        public static object FromPrimaryKeyWeak(Type modelType, object value)
        {
            // Use reflection to invoke the generic method
            MethodInfo mi = typeof(DataAccess).GetMethod("FromPrimaryKey", BindingFlags.Public | BindingFlags.Static);
            mi = mi.MakeGenericMethod(modelType);
            return mi.Invoke(null, new object[] { value });
        }

        #endregion
    }
}
