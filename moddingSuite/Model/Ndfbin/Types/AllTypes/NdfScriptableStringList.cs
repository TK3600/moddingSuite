using System.Collections.Generic;
using System.Linq;

namespace moddingSuite.Model.Ndfbin.Types.AllTypes
{
    public class NdfScriptableStringList
    {
        private readonly IList<NdfStringReference> Strings;

        public NdfScriptableStringList(IList<NdfStringReference> strings)
        {
            Strings = strings;
        }

        /// <summary>
        /// Easy string lookup by value for scripts.
        /// </summary>
        /// <returns></returns>
        public NdfString this[string value] => new NdfString(Strings.FirstOrDefault(cls => cls.Value == value));
    }
}
