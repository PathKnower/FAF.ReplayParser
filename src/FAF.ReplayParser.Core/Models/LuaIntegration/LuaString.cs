using System.Text;

namespace FAF.ReplayParser.Core.Models.LuaIntegration
{
    public class LuaString : LuaObject
    {
        public LuaString(byte[] content)
            : base(content)
        {}

        public LuaString(string luaString)
            : base()
        {
            Content = Encoding.UTF8.GetBytes(luaString);
        }
    }
}
