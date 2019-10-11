using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronicaSii.Extensions
{
    public class SimpleMessageInspector : IDispatchMessageInspector
    {
        public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            //try
            //{
            //    var svcLog = new ServicioLogAcceso();
            //    var svcUsuario = new ServicioUsuario();
            //    var consultaUsuario = new UsuarioConsultaEntidad
            //    {
            //        Filtro = new UsuarioConsultaFiltro
            //        {
            //            Identificador = OperationContext.Current.ServiceSecurityContext.PrimaryIdentity.Name,
            //        },
            //    };

            //    svcUsuario.Cargar(consultaUsuario);

            //    var usuario = consultaUsuario.Entidad;
            //    var now = DateTime.Now;

            //    svcLog.Guardar(new LogAcceso
            //    {
            //        UsuarioId = usuario.Id,
            //        UsuarioNombre = usuario.Nombre,
            //        Entrada = now,
            //        Mensaje = request.ToString(),
            //    });
            //}
            //catch (Exception e)
            //{
            //    Log.LogInfo(e.Message);

            //    throw new FaultException("Ocurrió un error al registrar la operación.");
            //}

            return null;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
        }
    }
}
