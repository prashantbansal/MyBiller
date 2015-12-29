using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DAO
{
    public static class DAOUtility
    {
        public static T TryGetValue<T>(this IDataReader dataReader, string keyName)
        {
            try
            {
                int ordinal = dataReader.GetOrdinal(keyName);
                return dataReader.TryGetValue<T>(ordinal);
            }
            catch (IndexOutOfRangeException ex)
            {
                throw ex;
            }
        }

        public static T TryGetValue<T>(this IDataReader dataReader, int ordinal)
        {
            if (ordinal < 0 || ordinal >= dataReader.FieldCount)
                return default(T);
            if (dataReader.IsDBNull(ordinal))
                return default(T);
            else
            {
                TypeConverter tc = TypeDescriptor.GetConverter(typeof(T));
                try
                {
                    if (typeof(IConvertible).IsAssignableFrom(typeof(T)))
                        return (T)tc.ConvertFrom(dataReader[ordinal].ToString());
                    else if (tc.CanConvertTo(typeof(string)))
                        return (T)tc.ConvertFrom(dataReader[ordinal].ToString());
                    else
                        return (T)dataReader[ordinal];
                }
                catch (FormatException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
