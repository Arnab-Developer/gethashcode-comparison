# GetHashCode comparison

This is a comparison of `Object.GetHashCode()` value between `class` and `record`.

The value of `Object.GetHashCode()` returns same value everytime for same object. But
it returns different values for `record` if you run the app multiple times. The reason 
may be that `record` overides `Object.GetHashCode()` internally and produce different 
values everytime you run the app.