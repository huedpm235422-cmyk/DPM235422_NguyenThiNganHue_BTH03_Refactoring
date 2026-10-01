using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSettingMethod_Refactoring
{
    public class Account_Before
    {
        private string _id;

        public Account_Before(string id)
        {
            _id = id;
        }

        // Hàm này dư thừa và nguy hiểm vì ID không nên bị đổi sau khi tạo
        public void SetId(string id)
        {
            _id = id;
        }

        public string GetId() => _id;
    }
}
