Console.Clear();
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double[] coords1A = {3,6,8};
double[] coords1B = {2,1,-7};

double[] coords2A = {7,-5, 0};
double[] coords2B = {1,-1,9};

double Distanse (double[] firstPoint, double[] secondPoint){
    int length = firstPoint.Length;
    double distSum = 0;
    double square = 2;
    double squareRoot = 0.5;
    for (int i = 0; i < length; i++){
        distSum += Math.Pow((firstPoint[i] - secondPoint[i]), square);
    }
    double dist = Math.Pow(distSum, squareRoot);
    return dist;
}

Console.WriteLine(Distanse(coords1A, coords1B));
Console.WriteLine(Distanse(coords2A, coords2B));