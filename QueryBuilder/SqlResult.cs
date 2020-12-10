using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SqlKata
{
    public class SqlResult
    {
        public Query Query { get; set; }
        public string RawSql { get; set; } = "";
        public List<object> Bindings { get; set; } = new List<object>();
        public string Sql { get; set; } = "";
        public Dictionary<string, object> NamedBindings = new Dictionary<string, object>();

        public override string ToString()
        {
            var deepParameters = Helper.Flatten(Bindings).ToList();

            return Helper.ReplaceAll(RawSql, "?", i =>
            {
                if (i >= deepParameters.Count)
                {
                    throw new Exception(
                        $"Failed to retrieve a binding at the index {i}, the total bindings count is {Bindings.Count}");
                }

                var value = deepParameters[i];
                return Helper.StringifyValue(value);
            });
        }



    }
}