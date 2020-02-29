UnityEngine.Object Extensions
===

## Why

1. Enable null-propagation
    ```c#
    var rb = GetComponent<Rigidbody>();
    rb.Nullable()?.AddForce(Vector3.forward);
    ```
   
2. Safe get component 
    ```c#
    var rb = GetOrAddComponent<Rigidbody>();
    rb.AddForce(Vector3.forward);
    ```
   
2. Unity unmanaged safe-check 
   ```c#
   Destroy(someUnityObject);
   
   print(someUnityObject == null);         // true
   
   object regularObject = someUnityObject;
   
   print(regularObject == null);           // false
   print(regularObject.IsUnityNull());     // true
   ```


## Install

Find `Packages/manifest.json` in your project and edit it to look like this:
```json
{
  "dependencies": {
    "com.codeavr.unity-object-extensions": "https://github.com/Codeavr/UnityObjectExtensions.git"
  }
}
```


### Requirements

* Unity any version
* Git

## License

* MIT
