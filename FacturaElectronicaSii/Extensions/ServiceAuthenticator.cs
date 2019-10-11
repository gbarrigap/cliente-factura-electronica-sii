using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronicaSii.Extensions
{
    public class ServiceAuthenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            //if (null == userName || null == password)
            //{
            //    throw new ArgumentNullException();
            //}
            //else
            //{
            //    try
            //    {
            //        Log.LogInfo(string.Format("Validando userName: {0} | password: {1}", userName, password));

            //        var svcUsuario = new ServicioUsuario();

            //        var consultaUsuario = new UsuarioConsultaEntidad
            //        {
            //            Filtro = new UsuarioConsultaFiltro
            //            {
            //                Identificador = userName,
            //            },
            //        };

            //        svcUsuario.Cargar(consultaUsuario);

            //        var usuario = consultaUsuario.Entidad;
            //        var sessionPassword = new Password(password, usuario.PasswordSalt);

            //        if (sessionPassword.Value != usuario.ContrasenaDigerida)
            //        {
            //            throw new FaultException(new FaultReason("Credenciales incorrectas"));
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Log.LogError(e.Message);

            //        throw new FaultException(e.Message);
            //    }
            //}
        }
    }
}
