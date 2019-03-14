using System.Collections.Generic;

namespace SqlKata.Values {
    public abstract class AbstractFunctionValue : AbstractValue {

        public List<object> Arguments { get; set; }

        public AbstractFunctionValue() {
            Arguments = new List<object>();
        }

    }
}
