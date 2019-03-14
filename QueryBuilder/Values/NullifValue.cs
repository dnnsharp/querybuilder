namespace SqlKata.Values {
    public class NullifValue : AbstractFunctionValue {

        public object Expression => Arguments[0];

        public object Comparator => Arguments[1];

        public NullifValue(object expression, object comparand) {
            Arguments.Add(expression);
            Arguments.Add(comparand);
        }

    }
}
