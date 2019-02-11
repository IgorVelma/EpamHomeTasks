package velma.igor;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

import java.io.File;
import java.util.concurrent.TimeUnit;

import static org.junit.Assert.*;

public class AuthorizationTest {
    WebDriver driver;
    String expectedName;
    String testLogin;
    String testPassword;
    boolean isChecked = false;

    @Before
    public void setUp() {
        File file = new File(".\\driver\\chromedriver.exe");
        System.setProperty("webdriver.chrome.driver", file.getAbsolutePath());
        this.driver = new ChromeDriver();
        this.driver.get("https://accounts.google.com");
        this.expectedName = "Добро пожаловать!";
        this.testLogin = "greengoblingreen28@gmail.com";
        this.testPassword = "1S3e4Fa7";

    }

    public void inputLogin(String testLogin) {
        WebElement loginField = this.driver.findElement(By.xpath("//*[@id='identifierId']"));
        loginField.sendKeys(testLogin);
        WebElement buttonNext = this.driver.findElement(By.xpath("//*[@id='identifierNext']"));
        buttonNext.click();
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
    }

    public void inputPassword(String testPassword) {
        WebElement passwordField = this.driver.findElement(By.xpath("//*[@aria-label='Введите пароль']"));
        passwordField.sendKeys(testPassword);
        WebElement buttonNext = this.driver.findElement(By.xpath("//*[@id='passwordNext']"));
        buttonNext.click();
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
    }

    public void checkTrue() {
        WebElement helloText = this.driver.findElement(By.xpath("//div//h1"));
        String helloTextInfo = helloText.getText();
        assertEquals(this.expectedName, helloTextInfo);
        this.isChecked = true;
    }

    public void checkInvalidInput() {
        this.expectedName = "Не удалось найти аккаунт Google";

        String invalidLogin = "tratratra@tra.tra";
        inputLogin(invalidLogin);
        WebElement labelOfInvalid = this.driver.findElement(By.xpath("//*[@aria-live='assertive']//div"));
        String labelOfInvalidText = labelOfInvalid.getText();
        assertEquals(this.expectedName, labelOfInvalidText);

    }

        @Test
    public void TestAuthorization(){
        inputLogin(this.testLogin);
        inputPassword(this.testPassword);
        checkTrue();
    }
    @Test
    public void TestInvalidAuthorization() {
        checkInvalidInput();
    }

    @After
    public void tearDown() {
        driver.quit();
    }

}