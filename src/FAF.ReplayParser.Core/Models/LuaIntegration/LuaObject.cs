namespace FAF.ReplayParser.Core.Models.LuaIntegration
{
    public class LuaObject
    {
        public LuaObject()
        {
        }

        public LuaObject(byte[] content)
        {
            Content = content;
        }

        public byte[] Content { get; set; }
    }
}
