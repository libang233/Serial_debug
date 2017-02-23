using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SML_serialTest
{
    public partial class translate_form : Form
    {
        enum keywords
        {
            INPUT = 0x10, PRINT,
            LOAD = 0x20, STORE, SET,
            ADD = 0x30, SUB, MUL, DIV, MOD, INC, _DEC, NEG,
            JMP = 0x40, JMPN, JMPZ, HALT,
            AND = 0x50, OR, XOR,
            PUSH = 0x60, POP, SREGA, SREGB, SREGC, SREGD,
            PMOD = 0x70, DWP, DRP, AWP, ARP,
            SLP = 0x80,
        };
        string[] var_table;
        string[] label_table;

        OpenFileDialog getPrefile = new OpenFileDialog();
        string SendPath ;
        string trans_text;
        public translate_form()
        {
            InitializeComponent();
        }

        private void choose_file_Click(object sender, EventArgs e)
        {
            getPrefile.InitialDirectory = Application.StartupPath;
            getPrefile.Filter = "";
            getPrefile.FilterIndex = 2;
            getPrefile.RestoreDirectory = true;    //是否从记忆上次目录
            if (getPrefile.ShowDialog() == DialogResult.OK)
            {
                SendPath = getPrefile.FileName.ToString();    //文件路径
                string Name = SendPath.Substring(SendPath.LastIndexOf("\\") + 1);
                prefile_textBox.Text = Name;
                trans_text = File.ReadAllText(SendPath);
            }
        }

        private  string[] pretranslate(string[] code)
        {
            string[] after_code= { };
            for (int i = 0; code[i] != null; i++)
            {
                string[] cmds = code[i].Split();
                if (cmds.Length > 0)
                {
                    if (cmds[0] == "DIM")
                    {
                        if (cmds.Length == 2)
                        {
                            cmds[cmds.Length] = "0";
                        }
                        if (cmds.Length > 2)
                        {
                            int id = Array.IndexOf(var_table, cmds[1]);
                            if (id != -1)
                            {
                                translated_Text.AppendText("[error] VAR " + cmds[1] + " ALREADY DEFINED.");
                                return null;
                            }
                            //var_table[cmds[1]] = cmds[2];
                        }
                    }
                    else if (cmds[0][0] == '.')
                    {
                        int id = Array.IndexOf(var_table, cmds[0]);
                        if (id != -1)
                        {
                            translated_Text.AppendText("[error] LABEL " + cmds[0] + " ALREADY DEFINED.");
                            return null;
                        }
                        //label_table[cmds[0]] = after_code.Length;
                    }
                    else if (cmds[0][0] == ';')
                    {

                    }
                    else
                    {
                        cmds.CopyTo(after_code, after_code.Length);
                    }
                }
            }
            for(int i=0; i < var_table.Length; i++)
            {
                
            }

            return after_code;

        }

        private string[] tanslate(string[] codes)
        {

        }
        
    }
}
