using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascoa02
{
    class Pessoas
    {
        public string name { get; set; }
        public string chocolate { get; set; }

        public override bool Equals(object obj)
        {
            var pessoas = obj as Pessoas;
            return pessoas != null &&
                   name == pessoas.name ;
        }

        public override int GetHashCode()
        {
            var hashCode = 1481013359;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            return hashCode;
        }
    }
}
