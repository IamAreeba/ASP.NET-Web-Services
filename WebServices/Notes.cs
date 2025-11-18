
// =========================================== 01: Web Servces Intro ===================================================
/*
   . These Web services has .asmx extension
   . So we are going to expose a method which takes 2 numbers add together and return there sum
   . So web service is basically a class and it has namespace which uniquely identify the web service 
   . This namespace is actually a string so usually it is company internet domain name 
   . Web services is inheriting from a class it not mandatory but if we are using .net session state or application state obj and we want direct access we can inherit from this
   . If u want the client to see the method u have to decorate it with web method attribute
   . WSDL = Web Services Description language
   . This is used by client to generate proxy classes 
   . I have created the add method for the app to invoke this method the app should create the SOAP message like below yellow req, res we seen and invoke this service method and parse the response 
   . We dont have to develop this req, res manually we will develop proxy classes which is going to do all the hard work for us 
   . We will see consuming a web service from a client app 
   .  To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
      // [System.Web.Script.Services.ScriptService
   . We will also see how to invoke a web service using asp.net ajax
   . WSDL doc formely define a web service
   . It contain all the methods that are exposed by a web service
   . Visual studio can generate a proxy class with the help of this WSDL document
   . We can invoke web service from any application e.g. Windows, Console, Desktop app
   . Even JAVA app can invoke a web service of .NET or vise versa

 */

