using Amazon.S3;
using Amazon.S3.Model;
using System.Text;



// image upload--------------------------------------------

//var s3Client = new AmazonS3Client();
//using var inputStream = new FileStream("D:\\Work\\Personal\\AWS\\AwsFundamentals\\6.S3\\S3Playground\\movies.jpg", FileMode.Open, FileAccess.Read);

//var putObjectRequest = new PutObjectRequest
//{
//    BucketName = "awsfundamenetalss3",
//    Key = "images/face.jpg",
//    ContentType = "image/jpeg",
//    InputStream = inputStream
//};

//await s3Client.PutObjectAsync(putObjectRequest);


//file upload --------------------------------------------------------------------

//var s3Client = new AmazonS3Client();
//using var inputStream = new FileStream("D:\\Work\\Personal\\AWS\\AwsFundamentals\\6.S3\\S3Playground\\movies.csv", FileMode.Open, FileAccess.Read);

//var putObjectRequest = new PutObjectRequest
//{
//    BucketName = "awsfundamenetalss3",
//    Key = "files/movies.csv",
//    ContentType = "text/csv",
//    InputStream = inputStream
//};

//await s3Client.PutObjectAsync(putObjectRequest);


// read file from s3 ----------------------------------------------------

var s3Client = new AmazonS3Client();

var getObjectRquest = new GetObjectRequest()
{
    BucketName = "awsfundamenetalss3",
    Key = "files/movies.csv",
};

var response  = await s3Client.GetObjectAsync(getObjectRquest);

using var memoryStream = new MemoryStream();
response.ResponseStream.CopyTo(memoryStream);

var text  = Encoding.Default.GetString(memoryStream.ToArray());

Console.WriteLine(text);