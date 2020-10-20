# README

This example demonstrates how to deploy a custom Windows Service in AWS Elastic Beanstalk. Note this code is provided as an example only, as-is and without warranty. This code should be used on a testing environment, and is not intended for  production usage.

The code is developed by AWS Senior Solutions Architect, Sepehr Samiei. Big thanks to Sepehr for this example :)

The video tutorial for this code is here:
* Deploying Windows Services in AWS Elastic Beanstalk, by Sepehr Samiei, Oct 2019 -  https://www.youtube.com/watch?v=hzF3E30-Jd8

Generally speaking, the code contains two parts:
1. A thin web application, as Elastic Beanstalk typically expects a web application
2. A custom Windows service, "SS test service" that every 60 seconds generates a new log entry in its service event log

Note in the video one step is to generate a pre-signed URL, and add the pre-signed URL to the "winservice.config" file.

## Next steps 

For ease of use, this example uses a pre-signed URL to download the custom service executable built from this code. Note however in production setups, it is recommended to use a more secure method to download files using S3Auth per steps in the below tutorial. While more setup is required, it avoids the need to regularly generate pre-signed URLs:
* Storing private keys securely in Amazon S3 - https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/https-storingprivatekeys.html

## References

For useful documentation for deploying on Elastic Beanstalk, and on Windows services, please see:
1. Customizing software on Windows servers - https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/customize-containers-windows-ec2.html
2. Customizing Windows Elastic Beanstalk Environments – Part 1 - https://aws.amazon.com/blogs/developer/customizing-windows-elastic-beanstalk-environments-part-1/
3. Tutorial: Create a Windows service app - https://docs.microsoft.com/en-us/dotnet/framework/windows-services/walkthrough-creating-a-windows-service-application-in-the-component-designer