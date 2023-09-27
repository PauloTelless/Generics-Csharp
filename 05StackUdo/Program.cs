using _05StackUdo;

EditorTexto texto = new EditorTexto();

texto.DigitarChar('S');
texto.DigitarChar('t');
texto.DigitarChar('a');
texto.DigitarChar('c');
texto.DigitarChar('q');

texto.UndoChar();

texto.DigitarChar('k');
texto.DigitarChar('!');
