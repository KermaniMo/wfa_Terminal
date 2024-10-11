using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class MsgBox
{
    public static DialogResult Show(string StrText)
    {
        wfa_Zabansara2.App_Source.Additional.frmMsg f = new wfa_Zabansara2.App_Source.Additional.frmMsg();
        f.ButtonCount = 1;
        //f.NameOfForm = string.Empty;
        f.lbl_Msg.Text = StrText;
        if (f.ShowDialog() == DialogResult.OK)
            return DialogResult.OK;
        return DialogResult.Cancel;

    }
    public static DialogResult Show(string StrText, string StrCaption)
    {
        wfa_Zabansara2.App_Source.Additional.frmMsg f = new wfa_Zabansara2.App_Source.Additional.frmMsg();

        f.ButtonCount = 1;
        //f.NameOfForm = StrCaption;
        f.lbl_Msg.Text = StrText;
        if (f.ShowDialog() == DialogResult.OK)
            return DialogResult.OK;
        return DialogResult.Cancel;

    }
    public static DialogResult Show(string StrText, string StrCaption, ButtonNumber BtnCount)
    {
        wfa_Zabansara2.App_Source.Additional.frmMsg f = new wfa_Zabansara2.App_Source.Additional.frmMsg();
        f.ButtonCount = ((int)BtnCount);
        //f.NameOfForm = StrCaption;
        f.lbl_Msg.Text = StrText;
        if (f.ShowDialog() == DialogResult.OK)
            return DialogResult.OK;
        return DialogResult.Cancel;

    }
  

}

public enum ButtonNumber
{
    OK = 1,
    OKCancel
}

