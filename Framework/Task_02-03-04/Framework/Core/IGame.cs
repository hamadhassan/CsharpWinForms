using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.Core
{
    public interface IGame
    {
        void risePlayerDieEvent(PictureBox pb);
    }
}
