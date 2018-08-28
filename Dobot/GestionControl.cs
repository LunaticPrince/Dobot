using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Input;
using System.Threading;

namespace Dobot
{
    public partial class GestionControl : UserControl
    {
        [DllImport("User32.dll")]
        public extern static int SetForegroundWindow(IntPtr point);

        ComboBox[] characterList = new ComboBox[8];
        List<Process> dofusProcesses = new List<Process>();
        Process dofusTarget;
        Key hotkey;
        bool detectHotKey;
        int currentIndex = 0;

        public GestionControl()
        {
            InitializeComponent();
            detectHotKey = false;
        }

        private void BtnAutoDetect_Click(object sender, EventArgs e)
        {
            // reset
            foreach (ComboBox c in characterList)
            {
                c.Items.Clear();
                c.Visible = false;
            }

            LabelPersonnages.Text = null;
            dropIni1.Items.Clear();
            Process[] processes = Process.GetProcesses();            

            int nbCharacters = 0;
            foreach (Process p in processes)
            {
                if (p.MainWindowTitle.Contains(" - Dofus "))
                {
                    dofusProcesses.Add(p);
                    nbCharacters++;
                }
            }

            for (int i = 0; i < nbCharacters; ++i)
            {
                characterList[i].Visible = true;
            }

            foreach (Process p in dofusProcesses)
            {
                foreach (ComboBox c in characterList)
                {
                    c.Items.Add(p.MainWindowTitle);
                }

                //dofusTarget = p;
                //IntPtr h = dofusTarget.MainWindowHandle;
                //SetForegroundWindow(h);
                LabelPersonnages.Text += p.MainWindowTitle + "\n";
            }
        }

        private void BtnHotkey_Click(object sender, EventArgs e)
        {
            hotkey = Key.None;
            detectHotKey = true;
        }

        private void BtnHotkey_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            hotkey = (Key) Enum.Parse(typeof(Key), e.KeyCode.ToString());
            LabelHotkeys.Text = e.KeyCode.ToString();
            label1.Focus();
            detectHotKey = false;
            
        }

        private void GestionControl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
        }

        private void GestionControl_Load(object sender, EventArgs e)
        {
            Thread Th = new Thread(Keyboardd);
            Th.SetApartmentState(ApartmentState.STA);
            CheckForIllegalCrossThreadCalls = false;
            Th.Start();

            characterList[0] = dropIni1;
            characterList[1] = dropIni2;
            characterList[2] = dropIni3;
            characterList[3] = dropIni4;
            characterList[4] = dropIni5;
            characterList[5] = dropIni6;
            characterList[6] = dropIni7;
            characterList[7] = dropIni8;

            foreach (ComboBox c in characterList)
            {
                c.Visible = false;
            }
        }

        //Detect Keystrokes
        bool isRunning = true;
        void Keyboardd()
        {
            while (isRunning)
            {
                Thread.Sleep(40);
                if (!detectHotKey && hotkey != Key.None && (Keyboard.GetKeyStates(hotkey) & KeyStates.Down) > 0)
                {
                    foreach (Process p in dofusProcesses)
                    {
                        
                        if (p.MainWindowTitle.ToString() == characterList[currentIndex].Text)
                        {
                            Process dofusTarget = p;
                            currentIndex++;

                            if (currentIndex >= characterList.Length)
                            {
                                currentIndex = 0;
                            }
                        }
                    }

                    if (dofusTarget != null)
                    {
                        IntPtr h = dofusTarget.MainWindowHandle;
                        SetForegroundWindow(h);
                    }
                }
            }
        }

        private void dropIni1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void dropIni2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void dropIni3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void dropIni4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void dropIni5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void dropIni6_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void dropIni7_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void dropIni8_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
        }
    }
}

