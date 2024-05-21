int scoreOfString(char* s) {
    int combo = 0;
    int firstVal = 0;
    int secondVal = 0;
    for (int x = 0; x < strlen(s); x++)
    {
        if(x+1 < strlen(s))
        {
            firstVal = s[x];
            secondVal = s[x+1];
        }
        if((firstVal-secondVal) > 0)
        {
            combo += firstVal - secondVal;
        }
        if((secondVal-firstVal) > 0)
        {
            combo += secondVal - firstVal;
        }
//        printf("firstval = %d, secondVal = %d, combo = %d\n",firstVal,secondVal,combo);
        firstVal = 0;
        secondVal = 0;
    }
    return combo;
}