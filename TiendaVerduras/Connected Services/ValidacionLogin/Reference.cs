﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaVerduras.ValidacionLogin {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ValidacionLogin.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VerificarAcceso", ReplyAction="http://tempuri.org/IService/VerificarAccesoResponse")]
        bool VerificarAcceso(string nombreusuario, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VerificarAcceso", ReplyAction="http://tempuri.org/IService/VerificarAccesoResponse")]
        System.Threading.Tasks.Task<bool> VerificarAccesoAsync(string nombreusuario, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CrearUsuario", ReplyAction="http://tempuri.org/IService/CrearUsuarioResponse")]
        bool CrearUsuario(string email, string pass, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CrearUsuario", ReplyAction="http://tempuri.org/IService/CrearUsuarioResponse")]
        System.Threading.Tasks.Task<bool> CrearUsuarioAsync(string email, string pass, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/TraerDato", ReplyAction="http://tempuri.org/IService/TraerDatoResponse")]
        string TraerDato(string dato, string tipo, string valor, string tabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/TraerDato", ReplyAction="http://tempuri.org/IService/TraerDatoResponse")]
        System.Threading.Tasks.Task<string> TraerDatoAsync(string dato, string tipo, string valor, string tabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ExisteInstancia", ReplyAction="http://tempuri.org/IService/ExisteInstanciaResponse")]
        bool ExisteInstancia(string referencia, string tabla, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ExisteInstancia", ReplyAction="http://tempuri.org/IService/ExisteInstanciaResponse")]
        System.Threading.Tasks.Task<bool> ExisteInstanciaAsync(string referencia, string tabla, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AgregarProducto", ReplyAction="http://tempuri.org/IService/AgregarProductoResponse")]
        bool AgregarProducto(string nombre, string unidad, int stock, int precio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AgregarProducto", ReplyAction="http://tempuri.org/IService/AgregarProductoResponse")]
        System.Threading.Tasks.Task<bool> AgregarProductoAsync(string nombre, string unidad, int stock, int precio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : TiendaVerduras.ValidacionLogin.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<TiendaVerduras.ValidacionLogin.IService>, TiendaVerduras.ValidacionLogin.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool VerificarAcceso(string nombreusuario, string pass) {
            return base.Channel.VerificarAcceso(nombreusuario, pass);
        }
        
        public System.Threading.Tasks.Task<bool> VerificarAccesoAsync(string nombreusuario, string pass) {
            return base.Channel.VerificarAccesoAsync(nombreusuario, pass);
        }
        
        public bool CrearUsuario(string email, string pass, string user) {
            return base.Channel.CrearUsuario(email, pass, user);
        }
        
        public System.Threading.Tasks.Task<bool> CrearUsuarioAsync(string email, string pass, string user) {
            return base.Channel.CrearUsuarioAsync(email, pass, user);
        }
        
        public string TraerDato(string dato, string tipo, string valor, string tabla) {
            return base.Channel.TraerDato(dato, tipo, valor, tabla);
        }
        
        public System.Threading.Tasks.Task<string> TraerDatoAsync(string dato, string tipo, string valor, string tabla) {
            return base.Channel.TraerDatoAsync(dato, tipo, valor, tabla);
        }
        
        public bool ExisteInstancia(string referencia, string tabla, string tipo) {
            return base.Channel.ExisteInstancia(referencia, tabla, tipo);
        }
        
        public System.Threading.Tasks.Task<bool> ExisteInstanciaAsync(string referencia, string tabla, string tipo) {
            return base.Channel.ExisteInstanciaAsync(referencia, tabla, tipo);
        }
        
        public bool AgregarProducto(string nombre, string unidad, int stock, int precio) {
            return base.Channel.AgregarProducto(nombre, unidad, stock, precio);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarProductoAsync(string nombre, string unidad, int stock, int precio) {
            return base.Channel.AgregarProductoAsync(nombre, unidad, stock, precio);
        }
    }
}
