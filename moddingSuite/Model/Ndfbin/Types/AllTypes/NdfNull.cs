using System;

namespace moddingSuite.Model.Ndfbin.Types.AllTypes
{
    public class NdfNull : NdfValueWrapper
    {
        public NdfNull()
            : base(NdfType.Unset)
        {
        }

        public override string ToString()
        {
            return "null";
        }

        public override byte[] GetBytes()
        {
            return null;
        }

        public override byte[] GetNdfText()
        {
            throw new NotImplementedException();
        }
    }
}