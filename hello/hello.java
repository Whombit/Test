package Test;

import java.util.Random;

public class hello {
    public static void main(String[] args) {
        Random random = new Random();
        String[] alphabet = {"a", "b", "c", "d", "e", "f",
                "g", "h", "i", "j", "k", "l",
                "m", "n", "o", "p", "q", "r",
                "s", "t", "u", "v", "w", "x",
                "y", "z", " " };

        boolean correct = false;
        String generatedString = "";

        while (!correct) {
            String[] helloWorld = new String[11]; // Array for hello world created to store every letter
            for (int i = 0; i < helloWorld.length; i++) {
                int rand_int = random.nextInt(alphabet.length);
                helloWorld[i] = alphabet[rand_int];
                System.out.println(generatedString);
            }
            generatedString = String.join("", helloWorld); // Convert the helloWorld array to a string
            if (generatedString.equals("hello world")) { // Compare the generated string with "hello world"
                correct = true;
            }
        }
        System.out.println(generatedString);
    }
}
