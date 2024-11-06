using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;



namespace WystawianieFS.Services
{
    public class NH_Service
    {
        private static string _CONNECTION_STRING = string.Empty;
        public static ISessionFactory SessionFactory { get; private set; }
        public static void Init(string CONNECTION_STRING, List<Type> CUSTOM_TYPES = null)
        {
            try
            {
                _CONNECTION_STRING = CONNECTION_STRING;
                ModelMapper mapper = new ModelMapper();
                if (CUSTOM_TYPES != null)
                {
                    mapper.AddMappings(CUSTOM_TYPES);
                }
                Configuration config = GetDbConfigurationNH();
                config.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), null);
                SessionFactory = config.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                throw ex;    
            }
        }
        private static Configuration GetDbConfigurationNH()
        {
            var configure = new Configuration();
            return configure.DataBaseIntegration(db =>
            {
                db.Dialect<MsSql2008Dialect>();
                db.Driver<SqlClientDriver>();
                db.ConnectionString = _CONNECTION_STRING;
                db.LogFormattedSql = false;
                db.LogSqlInConsole = false;
            });
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        public static IStatelessSession OpenStatelessSession()
        {
            return SessionFactory.OpenStatelessSession();
        }
    }
}
