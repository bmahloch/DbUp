using System;
using DbUp.Engine;
using DbUp.Engine.Transactions;

namespace DbUp.Builder
{
    public class ExecutedScriptEventArgs : EventArgs
    {
        private readonly string scriptName;
        private readonly string scriptContents;
        private readonly IConnectionManager connectionManager;

        internal ExecutedScriptEventArgs(SqlScript script, IConnectionManager iConnectionManager)
        {
            scriptName = script.Name;
            scriptContents = script.Contents;
            connectionManager = iConnectionManager;
        }

        /// <summary>
        /// Returns the connection manager for the script's execution.
        /// </summary>
        public IConnectionManager ConnectionManager
        {
            get { return connectionManager; }
        }

        /// <summary>
        /// Returns the name of the executed script.
        /// </summary>
        public string ScriptName
        {
            get { return scriptName; }
        }

        /// <summary>
        /// Returns the contents of the executed script.
        /// </summary>
        public string ScriptContents
        {
            get { return scriptContents; }
        }
    }
}
