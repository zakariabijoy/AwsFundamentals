using Amazon.S3;
using Amazon.S3.Model;


var s3Client = new AmazonS3Client();

// image upload--------------------------------------------

//using var inputStream = new FileStream("D:\\Work\\Personal\\AWS\\AwsFundamentals\\6.S3\\S3Playground\\movies.jpg", FileMode.Open, FileAccess.Read);

//var putObjectRequest = new PutObjectRequest
//{
//    BucketName = "awsfundamenetalss3",
//    Key = "images/face.jpg",
//    ContentType = "image/jpeg",
//    InputStream = inputStream
//};

//await s3Client.PutObjectAsync(putObjectRequest);

//file upload -----------------------

using var inputStream = new FileStream("D:\\Work\\Personal\\AWS\\AwsFundamentals\\6.S3\\S3Playground\\movies.csv", FileMode.Open, FileAccess.Read);

var putObjectRequest = new PutObjectRequest
{
    BucketName = "awsfundamenetalss3",
    Key = "files/movies.csv",
    ContentType = "text/csv",
    InputStream = inputStream
};

await s3Client.PutObjectAsync(putObjectRequest);