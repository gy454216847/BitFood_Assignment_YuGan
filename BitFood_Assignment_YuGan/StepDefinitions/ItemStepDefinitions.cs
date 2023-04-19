using BitFood_Assignment_YuGan.Core;
using BitFood_Assignment_YuGan.Pages;

using NUnit.Framework;

using OpenQA.Selenium;

using System;
using TechTalk.SpecFlow;

namespace BitFood_Assignment_YuGan.StepDefinitions
{
    [Binding]
    public class ItemStepDefinitions
    {
        [Given(@"I am login bitfood web with (.*) and (.*)")]
        public void GivenIAmLoginBitfoodWebWithUserNameAndPassword(string username, string password)
        {
            LoginPage.Login(username, password);
        }

        [When(@"I search an (.*) in the search bar")]
        public void WhenISearchAnItemInTheSearchBar(string item)
        {
            MainPage.SearchItem(item);
        }
        [Then(@"I should see the item in the search result")]
        public void ThenIShouldSeeTheItemInTheSearchResult()
        {
            Assert.IsTrue(CommonWeb.IsElementExist(ResultPage.ResultItem));
        }
        [When(@"I add item to basket")]
        public void WhenIAddItemToBasket()
        {
            CommonWeb.Click(ResultPage.AddButton);
        }

        [Then(@"I can see the item in my basket")]
        public void ThenICanSeeTheItemInMyBasket()
        {
           
            CommonWeb.Click(ResultPage.Trolley_tab);
            Assert.IsTrue(CommonWeb.IsElementExist(ResultPage.ResultItem));
        }

    }
}
