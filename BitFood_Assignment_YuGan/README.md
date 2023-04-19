# BitFood_Assignment_YuGan

Two UI test cases are included to verify that item can be searched for and added to the basket

# Requirements

To run this project, you will need:

- Visual Studio 2022 or later
- SpecFlow Visual Studio extension
- .NET Core 6.0 or later
- Chrome browser version 112 

- Install NuGet package ![](https://lh3.googleusercontent.com/pw/AJFCJaWzXSzqAJdWisrhx-RQb90XC3zAiXXwH5v4Bi5cy0X7kFi5kusQFb-MxC5DLnQnD9VLfD5Gt6VUNmQeNzAMJpPy32H3LR2oEQ3-h_MOdD-Tg7yz5A2BHLua8yMoZ01sCfab5MP68UJJLs7UoSH1_lp8zA3SCF1-cssNSqsCXjVsZNMULpzrzxe5FlBayg6osIdyktw2XiCMPbgptlaP-p28wkcqmHfzJHyJ0mIPDi4TQGOZptcTz7RQUxDO4qtuobtZFw8ms8bpxtfWSJf1-wMjEIfEDSWOgBR5sTseW9otYYzvL9f0zJA-L4Fa34y3g-wkQ5u2bk-O5aCSJCa3x_6LNdDtJF3Hbo4NJWQUJEBxaSKtZW8jwk3DTQmpFSMKKg5ht_mZsMKEbiKjy81ALbgulCSNfHzeVg1RdVyZ_yPNf17sUEoMFBhzeDCJzon0kOUF1jJpOjUWpi2YPxNEuFLSGQoL14rBCi-yiIeKOQVrsYDp96PDUZZ395Qp85gjQcwuPl_lTBVCq729VFN_EU-bJbmXIkmTTMRK0M97xP2Gjc7vUvlT6FijCYmLvLsTC2PoxVkl5Fn7HcKTG_bLE3qdqRk4ONSKZKiaHs7d5F_7ITKX4p-X7sDCQRIXwyNiNDkZa35Gc0q-t2RkB7pLGP5C0zi1n-R-Qeu713_eNzMobwfDOgOgnYMgTDqRirEcLha8oGWbV9ghJl30XXLgnO0L4X6PT_qkUnytjjw7DkWEfGrzx3VXZd5YUTtwYTSdvR9NaoCpT9Bkh7UvxKbhQLAzBaqK_XPCc0-MLhGGYenwHaDC9Op8rRQ54O4xXH8n4eEBMV195PIQs1A-OLcs4iSJykWiJohM1Dqw7G4wZej2I1VFyhjoYTARmdzkvKh7fJnjRw6mbGMSVIHIekYd0nP3=w442-h338-s-no?authuser=0)

```csproj
  <ItemGroup>
    <PackageReference Include="DotNetSeleniumExtras.WaitHelpers" Version="3.11.0" />
    <PackageReference Include="ExtentReports" Version="4.1.0" />
    <PackageReference Include="Gherkin" Version="26.0.3" />
    <PackageReference Include="log4net" Version="2.0.15" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.5.0" />
    <PackageReference Include="Selenium.Support" Version="4.8.2" />
    <PackageReference Include="Selenium.WebDriver" Version="4.8.2" />
    <PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="112.0.5615.4900" />
    <PackageReference Include="SpecFlow" Version="3.9.74" />
    <PackageReference Include="SpecFlow.Plus.LivingDocPlugin" Version="3.9.57" />
    <PackageReference Include="SpecFlow.NUnit" Version="3.9.74" />
    <PackageReference Include="nunit" Version="3.13.3" />
    <PackageReference Include="NUnit3TestAdapter" Version="4.4.2" />
    <PackageReference Include="FluentAssertions" Version="6.10.0" />
  </ItemGroup>
```

# Installation

1. Open the solution in Visual Studio.
2. Restore the NuGet packages.
3. Build the solution.
4. Open the Test Explorer window.
5. Click on "Run All" to run all the tests.

# Structure

The structure of the project: 

![](https://lh3.googleusercontent.com/pw/AJFCJaU48d5H0DnvYIWybHtiMP-Bss74uoeXb2bLs-417WWcIqji9JZL7qVlBOeMyijdAtJ7Esv-VxVKGEiED6d587I4rx4AHn6ffOBwRJVnd16ZLXinOWwO8Zee6Gto5qTtfkw_auN_0PcPL8bqjRXm6ARTaWyaud-4FYrgvaKXUr2fhYMSZbtujbk40RqdsMbzUqbCtDjhAXREzm5b3ZOhN2Ti1KRKz66Ou-bs-DEgc8ySHfr95j1ahMwgd3Tfo1HZdT0vPZCULhN0AYJO2FAkwJENswZMCIuH9agiwB3Gp_Dd1sfjtuwn0Cyb-Vb2KKBLud8Qh0zRj0pQpUJ_v3m6gvSPfjS-rZUjr-6asxkGtr9kAI_rBhK_uqr8pnbq5Rbfin5-M8oU84i4z-nL2rGnaT6jm-aDBizeiWWhyBwbvou5aDK3K0bavo1phSEHY3nh50covHvQRkFVkl89GEny6NBAtoT0KfxfHIyk67QymH2oBenAm4IrOFKR7facLPmHR5nybMQ8dSvyRyhPhFjQpoDuoCT0ja3FPq7gEx0hjeDD7ZyZXYJ8OStDIDiwwrIB3uywkJLIXhMQE5J1gFJQuoJyrPkzAZM2WU6EiB0LKUHMjy6zH7MeFfPt74BXkpwk88b-jmnNMuRabrCYEofZyT1_WauwrN32RPPBZy3nXnPJ0_gGwMdXjv5gmXw6t0gUC26E6uEUmmdH1EiEexDkR8bSA8Odydl-F9uGehAgoBSI6F3_LN0Vn4OVgKTgiWhDXnLBXejU7-smgyVywhPHw5KwxinA5heEAX0EYSolJiEg0LMznNHmq-TQq_dMPq8ql6IQHrUKzu3L2uHDr3QBnHIj31l7aaDYfmmOzdgqijMl1hd6ASrr6vn-ThcSSTlNf5zc8aPuC_xKTQVmR-KowvZs=w640-h792-s-no?authuser=0)



# Tech Stack

Selenium, Specflow, log4net, Extentreport, NUnit, Gherkin, PageObject

# Highlight

1. Store all configuration files in the config folder for easy management

2. Easily use selenium by calling the selenium APIs already wrapped in CommonWeb.cs

3. Easily run your browser by storing the `xxxdriver.exe` corresponding to your browser version in the Driver folder.

4. All daily log files are generated in the Logs folder and can show the location of the logged code, log time, log level and content

   ```log
   2023-04-18 23:44:18,128 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Open(58) | Open Browser: https://au-shopv5.uat.bdirectcloud.net/
   2023-04-18 23:44:21,089 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.MaxWindow(305) | Set max window
   2023-04-18 23:44:21,349 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Type(375) | Type the element with: BID384964
   2023-04-18 23:44:21,559 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Type(375) | Type the element with: YuGanTest3
   2023-04-18 23:44:23,731 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Click(349) | Click element:id=submitBtn
   2023-04-18 23:44:25,070 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Type(375) | Type the element with: cheese
   2023-04-18 23:44:27,792 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Quit(338) | Quit the browser
   2023-04-18 23:44:27,805 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Open(58) | Open Browser: https://au-shopv5.uat.bdirectcloud.net/
   2023-04-18 23:44:30,831 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.MaxWindow(305) | Set max window
   2023-04-18 23:44:31,048 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Type(375) | Type the element with: BID384964
   2023-04-18 23:44:31,243 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Type(375) | Type the element with: YuGanTest3
   2023-04-18 23:44:32,772 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Click(349) | Click element:id=submitBtn
   2023-04-18 23:44:34,305 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Type(375) | Type the element with: 160640
   2023-04-18 23:44:35,336 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Click(349) | Click element:css=.hidden-mobile:nth-child(3) .btn > .ng-scope
   2023-04-18 23:44:35,454 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Click(349) | Click element:class=trolley-tab
   2023-04-18 23:44:35,797 INFO [NonParallelWorker] BitFood_Assignment_YuGan.Core.CommonWeb.Quit(338) | Quit the browser
   ```

5. Easy to manage  Extent Reports which are generated in the reports folder which sort by date, under each date sort by time

6. This report can log information such as testers,test environment test start time, test end time, features, test results, etc.

7.  If the test fails, a screenshot will be included in the report![](https://lh3.googleusercontent.com/pw/AJFCJaXM7rV2pL17HyAVrotsu7dIsoSWb7mNO4hhs5TiDO0iWKlGbHGrymDfeqrwCPAqcsjRtoW_cJWGaMgaUT-x-DP2_X8Hav3mqeFWLWsm7_cEa-6r_DI29s-oCExn9RNWcm9MfsY_rI35jO1zJvCFC_A74DyuDPUoNsm971dPJ-pnKIAM86XtzP3kKiWvqdVZCfUtsQa-z13Q1Poo1Ra5nwnXR2F16eO6iZAMt5gjqmzepgRcGq_ho1ftKzZiedH4eg42kp9JOiaLP4IzUSrMsiYeC_eQQhKaySIKvU3iagKMhctbIpjkT_kORpWcWxT0HEndPq3fRxxMjXHcEUHRoWIyFtRBiJro0YqwEGEyIZSswHtOLfeVsBRCPzFivVkWni0v0c3Ohd2WnQcLtVu3Oq_0-gV5P8RblBzFeVV1m4XF7sWBqMe3LTwYd32wuPkbSSjgwGrl-WOglpqhL7oZA8SAgdvnMhb44D78xCSyiQ8F5WxfN0lzSj_wiQvKLwkNXP57vfBONpTSQ0WK9Ji4Tz_ZbCxIW1tdn60blrkAl5hfnslEGsNBcM1A2F31mN9Xv5VAFut4h9BnJdRA7ZPHURN3fNff_6AwFxWHqt8n2jmwUMboT2dHagxY41wuryevb2sFpNlA-DZu-xrlDnxm_eoLp5uZ_YRKRPAxTh18KEzQ605Y-R0e4dnHU_factnpaQFjT6S2ef6ZGB4A_sPNEcrUvIFI1hJY4IiJKiVsZipCp-l2KqsITNuXWz3jDOIGdwIGmMzx1tuGDeFFjnDvOIqwSmYde-j5PGj_WYqVOM6m2plxKCLDQEL-5TkUkcLdvaHulMP3tLvEzgQvZEbZ5qYJO0hbxfnJTt5ClXtzmiMPnvO0vAvJQNRxKc-DuMxK9DBJgKnuRKitt3ZGL_N7aYGh=w1841-h893-s-no?authuser=0)

8. All failed screenshots will also be stored in the screenshots folder to distinguish the time of the screenshot
