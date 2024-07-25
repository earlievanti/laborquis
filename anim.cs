// Example in C#
// Assuming faceCorners is a List<Tuple<T1, T2>> and faces is an array or List of some type Face

// Iterating over elements using a loop
for (int i = 0; i < faceCorners.Count; i++)
{
    // Accessing Item1 from faceCorners[i]
    var item1 = faceCorners[i].Item1;

    // Accessing an element from faces array
    var face = faces[i];

    // Now you can use item1 and face as needed
    Console.WriteLine($"Item1: {item1}, Face: {face}");
}
