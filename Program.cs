var registrarHelper = Type.GetType("ObjCRuntime.RegistrarHelper, Microsoft.MacCatalyst");
var lookupRegisteredTypeId = registrarHelper.GetMethod("LookupRegisteredTypeId", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
Console.WriteLine(lookupRegisteredTypeId.Invoke(null, new object[] { typeof(Foundation.NSString) }));
