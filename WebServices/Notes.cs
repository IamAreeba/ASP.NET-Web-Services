
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


// =========================================== 02: Consuming a web service ============================================
/*
   Object: Consuming a web service from a client application
    . So we have added the service reference in our web app of another class and our web app got that proxy class so he use that 
    . So our client app will now communicate with that proxy class and that proxy class is going to invoke that web service method
    . Visual Studio uses the WSDL to create a proxy class for us.
    . The client app calls the method of the proxy class (not the web service directly).
    . The proxy class converts the parameters into SOAP and sends the request to the web service.
    . The web service runs the method and sends back a SOAP response.
    . The proxy class converts the SOAP response back into normal .NET objects.
    . The client app then receives the normal result.
    . Developers don’t need to manually handle serialization or deserialization — the proxy does all the work.

 */

