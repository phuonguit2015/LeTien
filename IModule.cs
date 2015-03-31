using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeTien
{
    public interface IModule
    {
        // gồm các hàm
        void Reload();
        void New();
        void Edit();
        void Delete();
        //void Save();

        void Preview();
        void ExportXls();
    }

    public interface IMain
    {
        void SetAlertString(string caption, string text, IconAlert icon);
    }
    public enum IconAlert
    {
        None = 0,
        Done = 1,
        Warning = 2
    }
}
