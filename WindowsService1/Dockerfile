FROM microsoft/dotnet-framework
SHELL ["powershell", "-command"]
RUN New-Item -path c:\winservice -itemtype Directory
COPY . c:\\winservice
RUN New-Service -Name \"SSTestService\" -BinaryPathName \"c:\winservice\WindowsService1.exe\" -DisplayName \"SS Test Service\" -StartupType Automatic -Description \"This is a test service.\";
#ENTRYPOINT Start-Service -Name "SSTestService"
ENTRYPOINT ["powershell"]
CMD Start-Service -Name \"SSTestService\"; \	
    do \
    {; \
      start-sleep -Seconds 10; \	
	  $service = Get-Service  -Name \"SSTestService\"; \
    } while ($service.Status -eq "Running")