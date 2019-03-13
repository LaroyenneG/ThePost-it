using System;
using System.Windows.Forms;

namespace ThePost_it
{
    internal static class Program
    {
        /// <summary>
        ///     Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = new Model();
            var postitEditor = new PostitEditor();
            var group = new ControlGroup(model, postitEditor);

            Application.Run(postitEditor);
        }
    }
}