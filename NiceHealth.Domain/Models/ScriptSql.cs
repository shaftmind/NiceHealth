namespace NiceHealth.Domain.Models
{
    public class ScriptSql
    {

        public ScriptSql(string script)
        {
            Script = script;
        }

        public ScriptSql(string script, object parametros) : this(script)
        {
            Parametros = parametros;
        }

        public string Script { get;}
        public object Parametros { get;}
    }
}
