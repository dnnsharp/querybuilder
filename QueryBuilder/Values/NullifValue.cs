namespace SqlKata.Values {
    public class NullifValue : AbstractFunctionValue {

        public object Expression => Arguments[0];

        public object Condition => Arguments[1];

        public NullifValue(object expression, object condition) {
            Arguments.Add(expression);
            Arguments.Add(condition);
        }

    }
}
