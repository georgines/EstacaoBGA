void setup() {
  // put your setup code here, to run once:

}

void loop() {
  // put your main code here, to run repeatedly:

}


boolean isFloat(String tString) {
  String tBuf;
  boolean decPt = false;

  if (tString.charAt(0) == '+' || tString.charAt(0) == '-')
    tBuf = &tString[1];
  else
    tBuf = tString;

  for (unsigned int x = 0; x < tBuf.length(); x++) {
    if (tBuf.charAt(x) == '.') {
      if (decPt)
        return false;
      else
        decPt = true;
    } else if (tBuf.charAt(x) < '0' || tBuf.charAt(x) > '9')
      return false;
  }
  return true;
}
