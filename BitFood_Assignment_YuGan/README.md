# BitFood_Assignment_YuGan

Two UI test cases are included to verify that item can be searched for and added to the basket

# Requirements

To run this project, you will need:

- Visual Studio 2022 or later
- SpecFlow Visual Studio extension
- .NET Core 6.0 or later
- Chrome browser version 112

- Install NuGet package ![](https://lh3.googleusercontent.com/pw/AJFCJaU3blCJFqmL8d_SLEc_CJzVdgYF_WyaY02RLcQjsts8W-VsbxxtOv4kYVIqHzmGPNWhptSVYi495q1djTBHWdgv883GKxK-Rhpg_F34hikLnIEmRJjOhwjILbff9hp_VJYTee_mr3hcOL6gaQf93OymFfGbma8JdI5lS9u3GTFmcOYuYIuqBbsUm1ue0-Kheud-W52sjCcrBSNLerjCEprUbZW5XlCYupOX4xZ9EpiZDD5mCD6Lozk1QO0Vw75pRganozJRlcFWCB46dAGrkPjfRb5MC_5k-WzPXwo_GmyGsDIiR2Lu1lsxaBLAepPTkZUFX1xM8DsGD4iLdh-CTT6h8OG7jNcgTPGpotebWhvHmHi26ZjWBQrDbNE0aY3_fVQAmk-malX1ETvpw9rVSdqk7hbhO_fjes4-Xw4na1NSBShuNwek3P1ImXLuCyO8x7X5S0I5SZXxpm8KSCboF8av19iQRbRyXKG9bJ142ZSDPdf3q-vjqfofDZvaZ1hRKHp9kqghkyrY-h-rsCJ7SakChSVAk9dymyN4zzh4jiWuGukYQSM8v3icgiEySd7vrgWSk-4o7RQCQYSA5tRRwlMLUSHvAZfBctxyd6cwkdBhjeYkRxAw42ystNho_fQd5DFru1zKUoIa7y-cxGsN4Ms7TPxS6RESq_BOkf0d-IECucHFmSqDMZcm-IKWSspPfVeJMvtJNQ2R7oe7QFxVAJOLNwj1sBCxr96aZ4zlg6f4OudvTTOEqyfELgt7rurNTrv5WbK2xd3CfYABlE1Xk1QPtY7cUvj3kwRAlVC9e0nkUFPYUnvpKWVW-FDNw2lHTc0uEenT0Afy17OeHXrJm7M3Uo4QI2aHGABqqmyEzyoD_dBMj02rvL9a6wHY7uJ6aLNy-mYUmDkWYAgCIWinRV7W=w442-h338-s-no?authuser=0)

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

![](https://lh3.googleusercontent.com/pw/AJFCJaWku2KhGiVqLIdhP8GUdrgZFrhnYJo082WLP4lrSYhBxfFOM8leWu2k9RtXy3iqh3FN33RLQHtPkj5Yi54bd3jUs0BbEBMk0x8o28bpVOSlIwW9p3ZjNekAmtrGBPEJ6yLhIw5pF9dzwhum7MqTGFe1Yb_jSAP-LkaFnfD_rhhyokO96-yavKGp5AL4zfcjDf6zXZoOY7Bmkrn5faUc_qAkoHdzpSGACzw3VQAuSt8SmzEvrUqBwH7k9F8nZ5tG-1pQM22_lR_PHWMTSlqp4MRAOY6kAhqgUHe0fSms2WmgitdW79esa-kWDe-_zXiuOEb-OnbYwgcv_pTTMc0mjhZBtelpcjWNgHazjWczsr2xqA9in-_5zUroHpSr4G09ip5A5mFFhG2fuVYrj7LnJWQ-OVIndGDqmOenxpUFsG4AXMUs6J94-04Ri-TILcmzhcDIeznAdS4krP0yGzGncH3I8nqm67Lf_4FlGw-ppDET66vukGCR5hjMJjmm91oSF8TKC9L7Y96QgSYyMY0CDXGNe43JVdENrpMncOUhLFyC1yxzvaqFABjErbxpq4IpK9a6I0Z2uSO7-J-iGLRLByXfaoDn6C8KvmfuQ5iQMDiaiehxY6QxWA78gPMWsPTGAVen-lwXJF8oU57GUDaMiX4JYppGLNSHkI9F0r7HrJ9m4JLnFizAZvhZ6o38XjNo70l8yflqy5-hSi3fEhB2mY4r9mwFoV0ARx8azPdgE-ryPvThlZe1QteWjRmz9-wU7IzoDok1aqDLBWZJwNUy4rVcgVgMFHcBTaDEF2X_lBT0Re9Y1GAG2EyRok0t0b-XXwhZl-YG6ptsVzHVrWcEK6apD31OGk50CuTwqXJv9AjEQETL0-jBAiO_-lBIxX6sK7GHKDViPxYUMSk3l8ec4ETC=w640-h792-s-no?authuser=0)

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

5. Easy to manage Extent Reports which are generated in the reports folder which sort by date, under each date sort by time

6. This report can log information such as testers,test environment test start time, test end time, features, test results, etc.

7. If the test fails, a screenshot will be included in the report![](https://lh3.googleusercontent.com/pw/AJFCJaXM7rV2pL17HyAVrotsu7dIsoSWb7mNO4hhs5TiDO0iWKlGbHGrymDfeqrwCPAqcsjRtoW_cJWGaMgaUT-x-DP2_X8Hav3mqeFWLWsm7_cEa-6r_DI29s-oCExn9RNWcm9MfsY_rI35jO1zJvCFC_A74DyuDPUoNsm971dPJ-pnKIAM86XtzP3kKiWvqdVZCfUtsQa-z13Q1Poo1Ra5nwnXR2F16eO6iZAMt5gjqmzepgRcGq_ho1ftKzZiedH4eg42kp9JOiaLP4IzUSrMsiYeC_eQQhKaySIKvU3iagKMhctbIpjkT_kORpWcWxT0HEndPq3fRxxMjXHcEUHRoWIyFtRBiJro0YqwEGEyIZSswHtOLfeVsBRCPzFivVkWni0v0c3Ohd2WnQcLtVu3Oq_0-gV5P8RblBzFeVV1m4XF7sWBqMe3LTwYd32wuPkbSSjgwGrl-WOglpqhL7oZA8SAgdvnMhb44D78xCSyiQ8F5WxfN0lzSj_wiQvKLwkNXP57vfBONpTSQ0WK9Ji4Tz_ZbCxIW1tdn60blrkAl5hfnslEGsNBcM1A2F31mN9Xv5VAFut4h9BnJdRA7ZPHURN3fNff_6AwFxWHqt8n2jmwUMboT2dHagxY41wuryevb2sFpNlA-DZu-xrlDnxm_eoLp5uZ_YRKRPAxTh18KEzQ605Y-R0e4dnHU_factnpaQFjT6S2ef6ZGB4A_sPNEcrUvIFI1hJY4IiJKiVsZipCp-l2KqsITNuXWz3jDOIGdwIGmMzx1tuGDeFFjnDvOIqwSmYde-j5PGj_WYqVOM6m2plxKCLDQEL-5TkUkcLdvaHulMP3tLvEzgQvZEbZ5qYJO0hbxfnJTt5ClXtzmiMPnvO0vAvJQNRxKc-DuMxK9DBJgKnuRKitt3ZGL_N7aYGh=w1841-h893-s-no?authuser=0)

8. All failed screenshots will also be stored in the screenshots folder to distinguish the time of the screenshot

# Github:

https://github.com/gy454216847/BitFood_Assignment_YuGan.git
