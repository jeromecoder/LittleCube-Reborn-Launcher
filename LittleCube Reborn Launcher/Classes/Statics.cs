using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleCube_Reborn_Launcher.Classes
{
    class Statics
    {
        public static readonly Point PanelLocation = new Point(200, 0);
        public static readonly Size PanelSize = new Size(610, 450);
        public static readonly Size FormSize = new Size(897, 455);
        public static readonly String RegRootLauncher = "SOFTWARE\\LittleCube-Reborn\\Launcher\\";
        public static readonly String RegRootIdentifiants = "SOFTWARE\\LittleCube-Reborn\\Launcher\\Identifiants";
    }
}
