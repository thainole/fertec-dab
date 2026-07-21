using pe.com.fertec.bo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace pe.com.fertec.ui.util
{
    public class Util
    {

        //creamos una funcion para la sesion del empleado
        public static EmpleadoBO empleadoactual { get; set; }

        //procedimiento para cerrar la sesion
        public static void CerrarSesion()
        {
            empleadoactual = null;
        }


        /// <summary>
        /// Muestra un mensaje configurable con MessageBox
        /// <para><b>Tipo de Botones</b>
        /// <list type="table">
        /// <listheader>
        /// <term>Valor</term>
        /// <description>Descripcion</description>
        /// </listheader>
        /// <item>
        /// <term>0</term>
        /// <description>Boton Aceptar</description>
        /// </item>
        /// <item>
        /// <term>1</term>
        /// <description>Boton Aceptar y Cancelar</description>
        /// </item>
        /// <item>
        /// <term>2</term>
        /// <description>Boton Anular, Reintentar y Omitir</description>
        /// </item>
        /// <item>
        /// <term>3</term>
        /// <description>Boton Si, No Y Cancelar</description>
        /// </item>
        /// <item>
        /// <term>4</term>
        /// <description>Boton Si y No</description>
        /// </item>
        /// <item>
        /// <term>5</term>
        /// <description>Boton Reintentar y Cancelar</description>
        /// </item>
        /// <item>
        /// <term>6</term>
        /// <description>Boton Cancelar, Reintentar y Continuar</description>
        /// </item>
        /// </list>
        /// </para>
        /// 
        /// <para><b>Tipo de Iconos</b>
        /// <list type="table">
        /// <listheader>
        /// <term>Valor</term>
        /// <description>Descripcion</description>
        /// </listheader>
        /// <item>
        /// <term>16</term>
        /// <description>Icono Error / Mano</description>
        /// </item>
        /// <item>
        /// <term>32</term>
        /// <description>Icono Pregunta</description>
        /// </item>
        /// <item>
        /// <term>48</term>
        /// <description>Icono Advertencia / Exclamacion</description>
        /// </item>
        /// <item>
        /// <term>64</term>
        /// <description>Icono Informacion / Asterisco</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="titulo"></param>
        /// <param name="tipoboton"></param>
        /// <param name="tipoicono"></param>
        public static DialogResult MensajePersonalizado(
            string mensaje,
            string titulo,
            int tipoboton = 0,
            int tipoicono = 0)
        {
            //Tipo de Boton
            //MessageBoxButtons.OK -> Boton Aceptar ->0
            //MessageBoxButtons.OKCancel -> Boton Aceptar y cancelar ->1
            //MessageBoxButtons.AborRetryIgnore -> Boton anular, reintentar y omitir ->2
            //MessageBoxButtons.YesNoCancel -> Boton si,no y cancelar -3
            //MessageBoxButtons.YesNo -> Boton si y no ->4
            //MessageBoxButtons.RetryCancel -> Boton reintentar y cancelar ->5
            //MessageBoxButtons.CancelTryContinue -> Boton cancelar,reintar de nuevo y continuar ->6

            //Tipo de Icono
            //MessageBoxIcon.None -> sin icono -> 0
            //MessageBoxIcon.Hand, MessageBoxIcon.Stop, MessageBoxIcon.Error -> icono de error ->16
            //MessageBoxIcon.Question -> icono de pregunta -> 32
            //MessageBoxIcon.Exclamation, MessageBoxIcon.Warning -> icono de advertencia -> 48
            //MessageBoxIcon.Asterisk, MessageBoxIcon.Information -> icono de informacion -> 64

            MessageBoxButtons btns = (MessageBoxButtons)tipoboton;
            MessageBoxIcon icons = (MessageBoxIcon)tipoicono;
            return MessageBox.Show(mensaje, titulo, btns, icons);
        }

        //creamos un procedimiento para cargar los formularios
        public static void AbrirFormulario<T>(Form mdiParent) where T : Form, new()
        {
            //si el formulario ya est abiero lo selecciona
            foreach (Form frm in mdiParent.MdiChildren)
            {
                if (frm is T)
                {
                    frm.Show();
                    frm.Activate();
                    return;
                }
            }

            Form formulario = new T();
            formulario.MdiParent = mdiParent;
            formulario.Show();
        }

        //creamos un procedimiento para cargar los formularios con parametros
        public static void AbrirFormulario(Form mdiParent, Form formulario)
        {
            //si el formulario ya est abiero lo selecciona
            foreach (Form frm in mdiParent.MdiChildren)
            {
                if (frm.GetType() == formulario.GetType())
                {
                    frm.Activate();
                    return;
                }
            }
            formulario.MdiParent = mdiParent;
            formulario.Show();
        }


    }
}
