package week09;

/**
 * Exception class for ArrayList.
 * Assignment, COSC241.
 * @author Ksmith, Sgrant.
 *
 */

@SuppressWarnings("serial")
public class EmptyPileException extends RuntimeException{
    @SuppressWarnings("serial")
    public EmptyPileException(String message) {
        super(message); 
    }
 
}
