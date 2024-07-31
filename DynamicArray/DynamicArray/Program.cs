

using BookTasks.DynamicArray;

var arr = new DynamicArray(5);

arr.PushBack(1);
arr.PushBack(2);
arr.PushBack(3);
arr.PushBack(4);
arr.PushBack(5);
Console.WriteLine(arr.GetCapacity());
arr.PushBack(6);
Console.WriteLine(arr.GetCapacity());
Console.WriteLine(arr.GetSize());
arr.PopBack();
Console.WriteLine(arr.GetSize());