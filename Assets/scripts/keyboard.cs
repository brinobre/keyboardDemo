using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour
{

    //ESC BTN AND F1 - F12
    private Animator EscPress;
    private Animator F1Press;
    private Animator F2Press;
    private Animator F3Press;
    private Animator F4Press;
    private Animator F5Press;
    private Animator F6Press;
    private Animator F7Press;
    private Animator F8Press;
    private Animator F9Press;
    private Animator F10Press;
    private Animator F11Press;
    private Animator F12Press;

    //NUMERALS

    private Animator Alpha1Press;
    private Animator Alpha2Press;
    private Animator Alpha3Press;
    private Animator Alpha4Press;
    private Animator Alpha5Press;
    private Animator Alpha6Press;
    private Animator Alpha7Press;
    private Animator Alpha8Press;
    private Animator Alpha9Press;
    private Animator Alpha0Press;

    //ALPHABET

    private Animator QPress;
    private Animator WPress;
    private Animator EPress;
    private Animator RPress;
    private Animator TPress;
    private Animator YPress;
    private Animator UPress;
    private Animator IPress;
    private Animator OPress;
    private Animator PPress;
    private Animator ÅPress;

    private Animator APress;
    private Animator SPress;
    private Animator DPress;
    private Animator FPress;
    private Animator GPress;
    private Animator HPress;
    private Animator JPress;
    private Animator KPress;
    private Animator LPress;
    private Animator ÖPress;
    private Animator ÄPress;

    private Animator ZPress;
    private Animator XPress;
    private Animator CPress;
    private Animator VPress;
    private Animator BPress;
    private Animator NPress;
    private Animator MPress;

    //COMMAND BTNS

    private Animator TabPress;
    private Animator CAPSPress;
    private Animator LeftShiftPress;
    private Animator LeftCTRLPress;
    private Animator LeftAltPress;
    private Animator SpacePress;
    // private Animator AltGrPress;
    private Animator MenuPress;
    private Animator RightCTRLPress;
    private Animator RightShiftPress;
    private Animator ReturnPress;
    private Animator BackspacePress;

    private Animator ScrollLockPress;
    private Animator PausePress;
    private Animator InsertPress;
    private Animator HomePress;
    private Animator PageUpPress;
    private Animator DeletePress;
    private Animator EndPress;
    private Animator PageDownPress;

    //MISC BTNS
    private Animator LeftBracketPress;
    private Animator SquigglyPress;
    private Animator CommaPress;
    private Animator PeriodPress;
    private Animator BackslashPress;
    private Animator SlashPress;
    private Animator UnderscorePress;
    private Animator PlusPress;

    //ARROW BTNS

    private Animator ArrowUpPress;
    private Animator ArrowDownPress;
    private Animator ArrowLeftPress;
    private Animator ArrowRightPress;




    void Start()
    {


        //ESC BTN AND F1 - F12

        EscPress = GetComponent<Animator>();
        F1Press = GetComponent<Animator>();
        F2Press = GetComponent<Animator>();
        F3Press = GetComponent<Animator>();
        F4Press = GetComponent<Animator>();
        F5Press = GetComponent<Animator>();
        F6Press = GetComponent<Animator>();
        F7Press = GetComponent<Animator>();
        F8Press = GetComponent<Animator>();
        F9Press = GetComponent<Animator>();
        F10Press = GetComponent<Animator>();
        F11Press = GetComponent<Animator>();
        F12Press = GetComponent<Animator>();

        //NUMERALS

        Alpha1Press = GetComponent<Animator>();
        Alpha2Press = GetComponent<Animator>();
        Alpha3Press = GetComponent<Animator>();
        Alpha4Press = GetComponent<Animator>();
        Alpha5Press = GetComponent<Animator>();
        Alpha6Press = GetComponent<Animator>();
        Alpha7Press = GetComponent<Animator>();
        Alpha8Press = GetComponent<Animator>();
        Alpha9Press = GetComponent<Animator>();
        Alpha0Press = GetComponent<Animator>();

        //ALPHABET

        QPress = GetComponent<Animator>();
        WPress = GetComponent<Animator>();
        EPress = GetComponent<Animator>();
        RPress = GetComponent<Animator>();
        TPress = GetComponent<Animator>();
        YPress = GetComponent<Animator>();
        UPress = GetComponent<Animator>();
        IPress = GetComponent<Animator>();
        OPress = GetComponent<Animator>();
        PPress = GetComponent<Animator>();
        ÅPress = GetComponent<Animator>();

        APress = GetComponent<Animator>();
        SPress = GetComponent<Animator>();
        DPress = GetComponent<Animator>();
        FPress = GetComponent<Animator>();
        GPress = GetComponent<Animator>();
        HPress = GetComponent<Animator>();
        JPress = GetComponent<Animator>();
        KPress = GetComponent<Animator>();
        LPress = GetComponent<Animator>();
        ÖPress = GetComponent<Animator>();
        ÄPress = GetComponent<Animator>();

        ZPress = GetComponent<Animator>();
        XPress = GetComponent<Animator>();
        CPress = GetComponent<Animator>();
        VPress = GetComponent<Animator>();
        BPress = GetComponent<Animator>();
        NPress = GetComponent<Animator>();
        MPress = GetComponent<Animator>();

        //COMMAND BTNS

        TabPress = GetComponent<Animator>();
        CAPSPress = GetComponent<Animator>();
        LeftShiftPress = GetComponent<Animator>();
        LeftCTRLPress = GetComponent<Animator>();
        LeftAltPress = GetComponent<Animator>();
        SpacePress = GetComponent<Animator>();
        // AltGrPress          = GetComponent<Animator>();
        MenuPress = GetComponent<Animator>();
        RightCTRLPress = GetComponent<Animator>();
        RightShiftPress = GetComponent<Animator>();
        ReturnPress = GetComponent<Animator>();
        BackspacePress = GetComponent<Animator>();

        ScrollLockPress = GetComponent<Animator>();
        PausePress = GetComponent<Animator>();
        InsertPress = GetComponent<Animator>();
        HomePress = GetComponent<Animator>();
        PageUpPress = GetComponent<Animator>();
        DeletePress = GetComponent<Animator>();
        EndPress = GetComponent<Animator>();
        PageDownPress = GetComponent<Animator>();

        //MISC BTNS

        LeftBracketPress    = GetComponent<Animator>();
        SquigglyPress       = GetComponent<Animator>();
        CommaPress          = GetComponent<Animator>();
        PeriodPress         = GetComponent<Animator>();
        BackslashPress      = GetComponent<Animator>();
        SlashPress          = GetComponent<Animator>();
        UnderscorePress     = GetComponent<Animator>();
        PlusPress           = GetComponent<Animator>();

        // ARROW BTNS

        ArrowUpPress    = GetComponent<Animator>();
        ArrowDownPress  = GetComponent<Animator>();
        ArrowLeftPress  = GetComponent<Animator>();
        ArrowRightPress = GetComponent<Animator>();
    }

    public void playEsc()
    {
        EscPress.SetBool("isPressed", true);
    }

    public void stopEsc()
    {
        EscPress.SetBool("isReleased", true);
    }

    public void playF1()
    {
        F1Press.SetBool("F1Pressed", true);
    }

    public void stopF1()
    {
        F1Press.SetBool("F1Released", true);
    }


    public void playF2()
    {
        F2Press.SetBool("F2Pressed", true);
    }

    public void stopF2()
    {
        F2Press.SetBool("F2Released", true);
    }

    public void playF3()
    {
        F3Press.SetBool("F3Pressed", true);
    }

    public void stopF3()
    {
        F3Press.SetBool("F3Released", true);
    }

    public void playF4()
    {
        F4Press.SetBool("F4Pressed", true);
    }

    public void stopF4()
    {
        F4Press.SetBool("F4Released", true);
    }

    public void playF5()
    {
        F5Press.SetBool("F5Pressed", true);
    }

    public void stopF5()
    {
        F5Press.SetBool("F5Released", true);
    }

    public void playF6()
    {
        F6Press.SetBool("F6Pressed", true);
    }

    public void stopF6()
    {
        F6Press.SetBool("F6Released", true);
    }

    public void playF7()
    {
        F7Press.SetBool("F7Pressed", true);
    }

    public void stopF7()
    {
        F7Press.SetBool("F7Released", true);
    }

    public void playF8()
    {
        F8Press.SetBool("F8Pressed", true);
    }

    public void stopF8()
    {
        F8Press.SetBool("F8Released", true);
    }

    public void playF9()
    {
        F9Press.SetBool("F9Pressed", true);
    }

    public void stopF9()
    {
        F9Press.SetBool("F9Released", true);
    }

    public void playF10()
    {
        F10Press.SetBool("F10Pressed", true);
    }

    public void stopF10()
    {
        F10Press.SetBool("F10Released", true);
    }

    public void playF11()
    {
        F11Press.SetBool("F11Pressed", true);
    }

    public void stopF11()
    {
        F11Press.SetBool("F11Released", true);
    }

    public void playF12()
    {
        F12Press.SetBool("F12Pressed", true);
    }

    public void stopF12()
    {
        F12Press.SetBool("F12Released", true);
    }

    public void playAlpha1()
    {
        Alpha1Press.SetBool("Alpha1Pressed", true);
    }

    public void stopAlpha1()
    {
        Alpha1Press.SetBool("Alpha1Released", true);
    }

    public void playAlpha2()
    {
        Alpha2Press.SetBool("Alpha2Pressed", true);
    }

    public void stopAlpha2()
    {
        Alpha2Press.SetBool("Alpha2Released", true);
    }

    public void playAlpha3()
    {
        Alpha3Press.SetBool("Alpha3Pressed", true);
    }

    public void stopAlpha3()
    {
        Alpha3Press.SetBool("Alpha3Released", true);
    }

    public void playAlpha4()
    {
        Alpha4Press.SetBool("Alpha4Pressed", true);
    }

    public void stopAlpha4()
    {
        Alpha4Press.SetBool("Alpha4Released", true);
    }

    public void playAlpha5()
    {
        Alpha5Press.SetBool("Alpha5Pressed", true);
    }

    public void stopAlpha5()
    {
        Alpha5Press.SetBool("Alpha5Released", true);
    }

    public void playAlpha6()
    {
        Alpha6Press.SetBool("Alpha6Pressed", true);
    }

    public void stopAlpha6()
    {
        Alpha6Press.SetBool("Alpha6Released", true);
    }

    public void playAlpha7()
    {
        Alpha7Press.SetBool("Alpha7Pressed", true);
    }

    public void stopAlpha7()
    {
        Alpha7Press.SetBool("Alpha7Released", true);
    }

    public void playAlpha8()
    {
        Alpha8Press.SetBool("Alpha8Pressed", true);
    }

    public void stopAlpha8()
    {
        Alpha8Press.SetBool("Alpha8Released", true);
    }

    public void playAlpha9()
    {
        Alpha9Press.SetBool("Alpha9Pressed", true);
    }

    public void stopAlpha9()
    {
        Alpha9Press.SetBool("Alpha9Released", true);
    }

    public void playAlpha0()
    {
        Alpha0Press.SetBool("Alpha0Pressed", true);
    }

    public void stopAlpha0()
    {
        Alpha0Press.SetBool("Alpha0Released", true);
    }

    public void playQ()
    {
        QPress.SetBool("QPressed", true);
    }

    public void stopQ()
    {
        QPress.SetBool("QReleased", true);
    }

    public void playW()
    {
        WPress.SetBool("WPressed", true);
    }

    public void stopW()
    {
        WPress.SetBool("WReleased", true);
    }

    public void playE()
    {
        EPress.SetBool("EPressed", true);
    }

    public void stopE()
    {
        EPress.SetBool("EReleased", true);
    }

    public void playR()
    {
        RPress.SetBool("RPressed", true);
    }

    public void stopR()
    {
        RPress.SetBool("RReleased", true);
    }

    public void playT()
    {
        TPress.SetBool("TPressed", true);
    }

    public void stopT()
    {
        TPress.SetBool("TReleased", true);
    }

    public void playY()
    {
        YPress.SetBool("YPressed", true);
    }

    public void stopY()
    {
        YPress.SetBool("YReleased", true);
    }

    public void playU()
    {
        UPress.SetBool("UPressed", true);
    }

    public void stopU()
    {
        UPress.SetBool("UReleased", true);
    }

    public void playI()
    {
        IPress.SetBool("IPressed", true);
    }

    public void stopI()
    {
        IPress.SetBool("IReleased", true);
    }

    public void playO()
    {
        OPress.SetBool("OPressed", true);
    }

    public void stopO()
    {
        OPress.SetBool("OReleased", true);
    }

    public void playP()
    {
        PPress.SetBool("PPressed", true);
    }

    public void stopP()
    {
        PPress.SetBool("PReleased", true);
    }

    public void playÅ()
    {
        ÅPress.SetBool("ÅPressed", true);
    }

    public void stopÅ()
    {
        ÅPress.SetBool("ÅReleased", true);
    }

    public void playA()
    {
        APress.SetBool("APressed", true);
    }

    public void stopA()
    {
        APress.SetBool("AReleased", true);
    }

    public void playS()
    {
        SPress.SetBool("SPressed", true);
    }

    public void stopS()
    {
        SPress.SetBool("SReleased", true);
    }

    public void playD()
    {
        DPress.SetBool("DPressed", true);
    }

    public void stopD()
    {
        DPress.SetBool("DReleased", true);
    }

    public void playF()
    {
        FPress.SetBool("FPressed", true);
    }

    public void stopF()
    {
        FPress.SetBool("FReleased", true);
    }

    public void playG()
    {
        GPress.SetBool("GPressed", true);
    }

    public void stopG()
    {
        GPress.SetBool("GReleased", true);
    }

    public void playH()
    {
        HPress.SetBool("HPressed", true);
    }

    public void stopH()
    {
        HPress.SetBool("HReleased", true);
    }

    public void playJ()
    {
        JPress.SetBool("JPressed", true);
    }

    public void stopJ()
    {
        JPress.SetBool("JReleased", true);
    }

    public void playK()
    {
        KPress.SetBool("KPressed", true);
    }

    public void stopK()
    {
        KPress.SetBool("KReleased", true);
    }

    public void playL()
    {
        LPress.SetBool("LPressed", true);
    }

    public void stopL()
    {
        LPress.SetBool("LReleased", true);
    }

    public void playÖ()
    {
        ÖPress.SetBool("ÖPressed", true);
    }

    public void stopÖ()
    {
        ÖPress.SetBool("ÖReleased", true);
    }

    public void playÄ()
    {
        ÄPress.SetBool("ÄPressed", true);
    }

    public void stopÄ()
    {
        ÄPress.SetBool("ÄReleased", true);
    }

    public void playZ()
    {
        ZPress.SetBool("ZPressed", true);
    }

    public void stopZ()
    {
        ZPress.SetBool("ZReleased", true);
    }

    public void playX()
    {
        XPress.SetBool("XPressed", true);
    }

    public void stopX()
    {
        XPress.SetBool("XReleased", true);
    }

    public void playC()
    {
        CPress.SetBool("CPressed", true);
    }

    public void stopC()
    {
        CPress.SetBool("CReleased", true);
    }

    public void playV()
    {
        VPress.SetBool("VPressed", true);
    }

    public void stopV()
    {
        VPress.SetBool("VReleased", true);
    }

    public void playB()
    {
        BPress.SetBool("BPressed", true);
    }

    public void stopB()
    {
        BPress.SetBool("BReleased", true);
    }

    public void playN()
    {
        NPress.SetBool("NPressed", true);
    }

    public void stopN()
    {
        NPress.SetBool("NReleased", true);
    }

    public void playM()
    {
        MPress.SetBool("MPressed", true);
    }

    public void stopM()
    {
        MPress.SetBool("MReleased", true);
    }

    public void playTab()
    {
        TabPress.SetBool("TabPressed", true);
    }

    public void stopTab()
    {
        TabPress.SetBool("TabReleased", true);
    }

    public void playCAPS()
    {
        CAPSPress.SetBool("CAPSPressed", true);
    }

    public void stopCAPS()
    {
        CAPSPress.SetBool("CAPSReleased", true);
    }

    public void playLeftShift()
    {
        LeftShiftPress.SetBool("LeftShiftPressed", true);
    }

    public void stopLeftShift()
    {
        LeftShiftPress.SetBool("LeftShiftReleased", true);
    }

    
    public void playLeftCTRL()
    {
        LeftCTRLPress.SetBool("LeftCTRLPressed", true);
    }

    public void stopLeftCTRL()
    {
        LeftCTRLPress.SetBool("LeftCTRLReleased", true);
    }



    public void playLeftAlt()
    {
        LeftAltPress.SetBool("LeftAltPressed", true);
    }

    public void stopLeftAlt()
    {
        LeftAltPress.SetBool("LeftAltReleased", true);
    }

    public void playSpace() 
    {
        SpacePress.SetBool("SpacePressed", true);
    }

    public void stopSpace()
    {
       SpacePress.SetBool("SpaceReleased", true);
    }

    public void playAltGr()
    {
       // AltGrPress.SetBool("AltGrPressed", true);
    }

    public void stopAltGr()
    {
     //   AltGrPress.SetBool("AltGrReleased", true);
    }

    public void playMenu()
    {
        MenuPress.SetBool("MenuPressed", true);
    }

    public void stopMenu()
    {
        MenuPress.SetBool("MenuReleased", true);
    }

    public void playRightCTRL()
    {
        RightCTRLPress.SetBool("RightCTRLPressed", true);
    }

    public void stopRightCTRL()
    {
        RightCTRLPress.SetBool("RightCTRLReleased", true);
    }

    public void playRightShift()
    {
        RightShiftPress.SetBool("RightShiftPressed", true);
    }

    public void stopRightShift()
    {
        RightShiftPress.SetBool("RightShiftReleased", true);
    }

    public void playReturn()
    {
        ReturnPress.SetBool("ReturnPressed", true);
    }

    public void stopReturn()
    {
        ReturnPress.SetBool("ReturnReleased", true);
    }

    public void playBackspace()
    {
        BackspacePress.SetBool("BackspacePressed", true);
    }

    public void stopBackspace()
    {
        BackspacePress.SetBool("BackspaceReleased", true);
    }

    public void playLeftBracket()
    {
        LeftBracketPress.SetBool("LeftBracketPressed", true);
    }

    public void stopLeftBracket()
    {
        LeftBracketPress.SetBool("LeftBracketReleased", true);
    }

    public void playSquiggly()
    {
        SquigglyPress.SetBool("SquigglyPressed", true);
    }

    public void stopSquiggly()
    {
        SquigglyPress.SetBool("SquigglyReleased", true);
    }

    public void playComma()
    {
        CommaPress.SetBool("CommaPressed", true);
    }

    public void stopComma()
    {
        CommaPress.SetBool("CommaReleased", true);
    }

    public void playPeriod()
    {
        PeriodPress.SetBool("PeriodPressed", true);
    }

    public void stopPeriod()
    {
        PeriodPress.SetBool("PeriodReleased", true);
    }

    public void playBackslash()
    {
        BackslashPress.SetBool("BackslashPressed", true);
    }

    public void stopBackslash()
    {
        BackslashPress.SetBool("BackslashReleased", true);
    }

    public void playSlash()
    {
        SlashPress.SetBool("SlashPressed", true);
    }

    public void stopSlash()
    {
        SlashPress.SetBool("SlashReleased", true);
    }

    public void playUnderscore()
    {
        UnderscorePress.SetBool("UnderscorePressed", true);
    }

    public void stopUnderscore()
    {
        UnderscorePress.SetBool("UnderscoreReleased", true);
    }

    public void playPlus()
    {
        PlusPress.SetBool("PlusPressed", true);
    }

    public void stopPlus()
    {
        PlusPress.SetBool("PlusReleased", true);
    }

    public void playScrollLock()
    {
        ScrollLockPress.SetBool("ScrollLockPressed", true);
    }

    public void stopScrollLock()
    {
        ScrollLockPress.SetBool("ScrollLockReleased", true);
    }

    public void playPause()
    {
        ScrollLockPress.SetBool("PausePressed", true);
    }

    public void stopPause()
    {
        ScrollLockPress.SetBool("PauseReleased", true);
    }

    public void playInsert()
    {
        InsertPress.SetBool("InsertPressed", true);
    }

    public void stopInsert()
    {
        InsertPress.SetBool("InsertReleased", true);
    }

    public void playHome()
    {
        HomePress.SetBool("HomePressed", true);
    }

    public void stopHome()
    {
        HomePress.SetBool("HomeReleased", true);
    }

    public void playPageUp()
    {
        PageUpPress.SetBool("PageUpPressed", true);
    }

    public void stopPageUp()
    {
        HomePress.SetBool("PageUpReleased", true);
    }

    public void playDelete()
    {
        DeletePress.SetBool("DeletePressed", true);
    }

    public void stopDelete()
    {
        DeletePress.SetBool("DeleteReleased", true);
    }

    public void playEnd()
    {
        EndPress.SetBool("EndPressed", true);
    }

    public void stopEnd()
    {
        EndPress.SetBool("EndReleased", true);
    }

    public void playPageDown()
    {
        PageDownPress.SetBool("PageDownPressed", true);
    }

    public void stopPageDown()
    {
        PageDownPress.SetBool("PageDownReleased", true);
    }

    public void playArrowUp()
    {
        ArrowUpPress.SetBool("ArrowUpPressed", true);
    }

    public void stopArrowUp()
    {
        ArrowUpPress.SetBool("ArrowUpReleased", true);
    }

    public void playArrowDown()
    {
        ArrowDownPress.SetBool("ArrowDownPressed", true);
    }

    public void stopArrowDown()
    {
        ArrowDownPress.SetBool("ArrowDownReleased", true);
    }

    public void playArrowLeft()
    {
        ArrowLeftPress.SetBool("ArrowLeftPressed", true);
    }

    public void stopArrowLeft()
    {
        ArrowLeftPress.SetBool("ArrowLeftReleased", true);
    }

    public void playArrowRight()
    {
        ArrowRightPress.SetBool("ArrowRightPressed", true);
    }

    public void stopArrowRight()
    {
        ArrowRightPress.SetBool("ArrowRightReleased", true);
    }
    // Update is called once per frame

        public void animations()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscPress.SetBool("isReleased", false);
            playEsc();
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            EscPress.SetBool("isPressed", false);
            stopEsc();
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            F1Press.SetBool("F1Released", false);
            playF1();
        }

        if (Input.GetKeyUp(KeyCode.F1))
        {
            F1Press.SetBool("F1Pressed", false);
            stopF1();
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            F2Press.SetBool("F2Released", false);
            playF2();
        }

        if (Input.GetKeyUp(KeyCode.F2))
        {
            F2Press.SetBool("F2Pressed", false);
            stopF2();
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            F3Press.SetBool("F3Released", false);
            playF3();
        }

        if (Input.GetKeyUp(KeyCode.F3))
        {
            F3Press.SetBool("F3Pressed", false);
            stopF3();
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            F4Press.SetBool("F4Released", false);
            playF4();
        }

        if (Input.GetKeyUp(KeyCode.F4))
        {
            F4Press.SetBool("F4Pressed", false);
            stopF4();
        }

        if (Input.GetKeyDown(KeyCode.F5))
        {
            F5Press.SetBool("F5Released", false);
            playF5();
        }

        if (Input.GetKeyUp(KeyCode.F5))
        {
            F5Press.SetBool("F5Pressed", false);
            stopF5();
        }

        if (Input.GetKeyDown(KeyCode.F6))
        {
            F6Press.SetBool("F6Released", false);
            playF6();
        }

        if (Input.GetKeyUp(KeyCode.F6))
        {
            F6Press.SetBool("F6Pressed", false);
            stopF6();
        }

        if (Input.GetKeyDown(KeyCode.F7))
        {
            F7Press.SetBool("F7Released", false);
            playF7();
        }

        if (Input.GetKeyUp(KeyCode.F7))
        {
            F7Press.SetBool("F7Pressed", false);
            stopF7();
        }

        if (Input.GetKeyDown(KeyCode.F8))
        {
            F8Press.SetBool("F8Released", false);
            playF8();
        }

        if (Input.GetKeyUp(KeyCode.F8))
        {
            F8Press.SetBool("F8Pressed", false);
            stopF8();
        }

        if (Input.GetKeyDown(KeyCode.F9))
        {
            F9Press.SetBool("F9Released", false);
            playF9();
        }

        if (Input.GetKeyUp(KeyCode.F9))
        {
            F9Press.SetBool("F9Pressed", false);
            stopF9();
        }

        if (Input.GetKeyDown(KeyCode.F10))
        {
            F10Press.SetBool("F10Released", false);
            playF10();
        }

        if (Input.GetKeyUp(KeyCode.F10))
        {
            F10Press.SetBool("F10Pressed", false);
            stopF10();
        }

        if (Input.GetKeyDown(KeyCode.F11))
        {
            F11Press.SetBool("F11Released", false);
            playF11();
        }

        if (Input.GetKeyUp(KeyCode.F11))
        {
            F11Press.SetBool("F11Pressed", false);
            stopF11();
        }

        if (Input.GetKeyDown(KeyCode.F12))
        {
            F12Press.SetBool("F12Released", false);
            playF12();
        }

        if (Input.GetKeyUp(KeyCode.F12))
        {
            F12Press.SetBool("F12Pressed", false);
            stopF12();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Alpha1Press.SetBool("Alpha1Released", false);
            playAlpha1();
        }

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Alpha1Press.SetBool("Alpha1Pressed", false);
            stopAlpha1();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Alpha2Press.SetBool("Alpha2Released", false);
            playAlpha2();
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Alpha2Press.SetBool("Alpha2Pressed", false);
            stopAlpha2();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Alpha3Press.SetBool("Alpha3Released", false);
            playAlpha3();
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Alpha3Press.SetBool("Alpha3Pressed", false);
            stopAlpha3();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Alpha4Press.SetBool("Alpha4Released", false);
            playAlpha4();
        }

        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            Alpha4Press.SetBool("Alpha4Pressed", false);
            stopAlpha4();
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Alpha5Press.SetBool("Alpha5Released", false);
            playAlpha5();
        }

        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            Alpha5Press.SetBool("Alpha5Pressed", false);
            stopAlpha5();
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Alpha6Press.SetBool("Alpha6Released", false);
            playAlpha6();
        }

        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            Alpha6Press.SetBool("Alpha6Pressed", false);
            stopAlpha6();
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Alpha7Press.SetBool("Alpha7Released", false);
            playAlpha7();
        }

        if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            Alpha7Press.SetBool("Alpha7Pressed", false);
            stopAlpha7();
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Alpha8Press.SetBool("Alpha8Released", false);
            playAlpha8();
        }

        if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            Alpha8Press.SetBool("Alpha8Pressed", false);
            stopAlpha8();
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Alpha9Press.SetBool("Alpha9Released", false);
            playAlpha9();
        }

        if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            Alpha9Press.SetBool("Alpha9Pressed", false);
            stopAlpha9();
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Alpha0Press.SetBool("Alpha0Released", false);
            playAlpha0();
        }

        if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            Alpha0Press.SetBool("Alpha0Pressed", false);
            stopAlpha0();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            QPress.SetBool("QReleased", false);
            playQ();
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            QPress.SetBool("QPressed", false);
            stopQ();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            WPress.SetBool("WReleased", false);
            playW();
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            WPress.SetBool("WPressed", false);
            stopW();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            EPress.SetBool("EReleased", false);
            playE();
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            EPress.SetBool("EPressed", false);
            stopE();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RPress.SetBool("RReleased", false);
            playR();
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            RPress.SetBool("RPressed", false);
            stopR();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            TPress.SetBool("TReleased", false);
            playT();
        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            TPress.SetBool("TPressed", false);
            stopT();
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            YPress.SetBool("YReleased", false);
            playY();
        }

        if (Input.GetKeyUp(KeyCode.Y))
        {
            YPress.SetBool("YPressed", false);
            stopY();
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            UPress.SetBool("UReleased", false);
            playU();
        }

        if (Input.GetKeyUp(KeyCode.U))
        {
            UPress.SetBool("UPressed", false);
            stopU();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            IPress.SetBool("IReleased", false);
            playI();
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            IPress.SetBool("IPressed", false);
            stopI();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            OPress.SetBool("OReleased", false);
            playO();
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            OPress.SetBool("OPressed", false);
            stopO();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            PPress.SetBool("PReleased", false);
            playP();
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            PPress.SetBool("PPressed", false);
            stopP();
        }

        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            ÅPress.SetBool("ÅReleased", false);
            playÅ();
        }

        if (Input.GetKeyUp(KeyCode.RightBracket))
        {
            ÅPress.SetBool("ÅPressed", false);
            stopÅ();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            APress.SetBool("AReleased", false);
            playA();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            APress.SetBool("APressed", false);
            stopA();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SPress.SetBool("SReleased", false);
            playS();
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            SPress.SetBool("SPressed", false);
            stopS();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            DPress.SetBool("DReleased", false);
            playD();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            DPress.SetBool("DPressed", false);
            stopD();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            FPress.SetBool("FReleased", false);
            playF();
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            FPress.SetBool("FPressed", false);
            stopF();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GPress.SetBool("GReleased", false);
            playG();
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            GPress.SetBool("GPressed", false);
            stopG();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            HPress.SetBool("HReleased", false);
            playH();
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
            HPress.SetBool("HPressed", false);
            stopH();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            JPress.SetBool("JReleased", false);
            playJ();
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            JPress.SetBool("JPressed", false);
            stopJ();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            KPress.SetBool("KReleased", false);
            playK();
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            KPress.SetBool("KPressed", false);
            stopK();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            LPress.SetBool("LReleased", false);
            playL();
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            LPress.SetBool("LPressed", false);
            stopL();
        }

        // Ö == BACKQUOTE BTN

        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            ÖPress.SetBool("ÖReleased", false);
            playÖ();
        }

        if (Input.GetKeyUp(KeyCode.BackQuote))
        {
            ÖPress.SetBool("ÖPressed", false);
            stopÖ();
        }

        // Ä == QUOTE BTN

        if (Input.GetKeyDown(KeyCode.Quote))
        {
            ÄPress.SetBool("ÄReleased", false);
            playÄ();
        }

        if (Input.GetKeyUp(KeyCode.Quote))
        {
            ÄPress.SetBool("ÄPressed", false);
            stopÄ();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            ZPress.SetBool("ZReleased", false);
            playZ();
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            ZPress.SetBool("ZPressed", false);
            stopZ();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            XPress.SetBool("XReleased", false);
            playX();
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            XPress.SetBool("XPressed", false);
            stopX();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            CPress.SetBool("CReleased", false);
            playC();
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            CPress.SetBool("CPressed", false);
            stopC();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            VPress.SetBool("VReleased", false);
            playV();
        }

        if (Input.GetKeyUp(KeyCode.V))
        {
            VPress.SetBool("VPressed", false);
            stopV();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            BPress.SetBool("BReleased", false);
            playB();
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            BPress.SetBool("BPressed", false);
            stopB();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            NPress.SetBool("NReleased", false);
            playN();
        }

        if (Input.GetKeyUp(KeyCode.N))
        {
            NPress.SetBool("NPressed", false);
            stopN();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            MPress.SetBool("MReleased", false);
            playM();
        }

        if (Input.GetKeyUp(KeyCode.M))
        {
            MPress.SetBool("MPressed", false);
            stopM();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TabPress.SetBool("TabReleased", false);
            playTab();
        }

        if (Input.GetKeyUp(KeyCode.Tab))
        {
            TabPress.SetBool("TabPressed", false);
            stopTab();
        }

        if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            CAPSPress.SetBool("CAPSReleased", false);
            playCAPS();
        }

        if (Input.GetKeyUp(KeyCode.CapsLock))
        {
            CAPSPress.SetBool("CAPSPressed", false);
            stopCAPS();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            LeftShiftPress.SetBool("LeftShiftReleased", false);
            playLeftShift();
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            LeftShiftPress.SetBool("LeftShiftPressed", false);
            stopLeftShift();
        }



        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            LeftCTRLPress.SetBool("LeftCTRLReleased", false);
            playLeftCTRL();
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            LeftShiftPress.SetBool("LeftCTRLPressed", false);
            stopLeftCTRL();
        }





        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            LeftAltPress.SetBool("LeftAltReleased", false);
            playLeftAlt();
        }

        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            LeftAltPress.SetBool("LeftAltPressed", false);
            stopLeftAlt();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpacePress.SetBool("SpaceReleased", false);
            playSpace();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            SpacePress.SetBool("SpacePressed", false);
            stopSpace();
        }

        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            //     AltGrPress.SetBool("AltGrReleased", false);
            // playAltGr();
        }

        if (Input.GetKeyUp(KeyCode.RightAlt))
        {
            //    AltGrPress.SetBool("AltGrPressed", false);
            // stopAltGr();
        }

        if (Input.GetKeyDown(KeyCode.Menu))
        {
            MenuPress.SetBool("MenuReleased", false);
            playMenu();
        }

        if (Input.GetKeyUp(KeyCode.Menu))
        {
            MenuPress.SetBool("MenuPressed", false);
            stopMenu();
        }

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            RightCTRLPress.SetBool("RightCTRLReleased", false);
            playRightCTRL();
        }

        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            RightCTRLPress.SetBool("RightCTRLPressed", false);
            stopRightCTRL();
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            RightShiftPress.SetBool("RightShiftReleased", false);
            playRightShift();
        }

        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            RightShiftPress.SetBool("RightShiftPressed", false);
            stopRightShift();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            ReturnPress.SetBool("ReturnReleased", false);
            playReturn();
        }

        if (Input.GetKeyUp(KeyCode.Return))
        {
            ReturnPress.SetBool("ReturnPressed", false);
            stopReturn();
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            BackspacePress.SetBool("BackspaceReleased", false);
            playBackspace();
        }

        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            BackspacePress.SetBool("BackspacePressed", false);
            stopBackspace();
        }

        // SQUIGGLY == SEMICOLON BTN

        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            SquigglyPress.SetBool("SquigglyReleased", false);
            playSquiggly();
        }

        if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            SquigglyPress.SetBool("SquigglyPressed", false);
            stopSquiggly();
        }

        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            LeftBracketPress.SetBool("LeftBracketReleased", false);
            playLeftBracket();
        }

        if (Input.GetKeyUp(KeyCode.LeftBracket))
        {
            LeftBracketPress.SetBool("LeftBracketPressed", false);
            stopLeftBracket();
        }

        if (Input.GetKeyDown(KeyCode.Comma))
        {
            CommaPress.SetBool("CommaReleased", false);
            playComma();
        }

        if (Input.GetKeyUp(KeyCode.Comma))
        {
            CommaPress.SetBool("CommaPressed", false);
            stopComma();
        }

        if (Input.GetKeyDown(KeyCode.Period))
        {
            PeriodPress.SetBool("PeriodReleased", false);
            playPeriod();
        }

        if (Input.GetKeyUp(KeyCode.Period))
        {
            PeriodPress.SetBool("PeriodPressed", false);
            stopPeriod();
        }

        if (Input.GetKeyDown(KeyCode.Backslash))
        {
            BackslashPress.SetBool("BackslashReleased", false);
            playBackslash();
        }

        if (Input.GetKeyUp(KeyCode.Backslash))
        {
            BackslashPress.SetBool("BackslashPressed", false);
            stopBackslash();
        }

        if (Input.GetKeyDown(KeyCode.Slash))
        {
            SlashPress.SetBool("SlashReleased", false);
            playSlash();
        }

        if (Input.GetKeyUp(KeyCode.Slash))
        {
            SlashPress.SetBool("SlashPressed", false);
            stopSlash();
        }


        // MINUS == UNDERSCORE BTN 
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            UnderscorePress.SetBool("UnderscoreReleased", false);
            playUnderscore();
        }

        if (Input.GetKeyUp(KeyCode.Minus))
        {
            UnderscorePress.SetBool("UnderscorePressed", false);
            stopUnderscore();
        }

        // EQUALS == PLUS BTN
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            PlusPress.SetBool("PlusReleased", false);
            playPlus();
        }

        if (Input.GetKeyUp(KeyCode.Equals))
        {
            PlusPress.SetBool("PlusPressed", false);
            stopPlus();
        }

        if (Input.GetKeyDown(KeyCode.ScrollLock))
        {
            ScrollLockPress.SetBool("ScrollLockReleased", false);
            playScrollLock();
        }

        if (Input.GetKeyUp(KeyCode.ScrollLock))
        {
            ScrollLockPress.SetBool("ScrollLockPressed", false);
            stopScrollLock();
        }

        if (Input.GetKeyDown(KeyCode.Pause))
        {
            PausePress.SetBool("PauseReleased", false);
            playPause();
        }

        if (Input.GetKeyUp(KeyCode.Pause))
        {
            PausePress.SetBool("PausePressed", false);
            stopPause();
        }

        if (Input.GetKeyDown(KeyCode.Insert))
        {
            InsertPress.SetBool("InsertReleased", false);
            playInsert();
        }

        if (Input.GetKeyUp(KeyCode.Insert))
        {
            InsertPress.SetBool("InsertPressed", false);
            stopInsert();
        }

        if (Input.GetKeyDown(KeyCode.Home))
        {
            HomePress.SetBool("HomeReleased", false);
            playHome();
        }

        if (Input.GetKeyUp(KeyCode.Home))
        {
            HomePress.SetBool("HomePressed", false);
            stopHome();
        }

        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            PageUpPress.SetBool("PageUpReleased", false);
            playPageUp();
        }

        if (Input.GetKeyUp(KeyCode.PageUp))
        {
            PageUpPress.SetBool("PageUpPressed", false);
            stopPageUp();
        }

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            DeletePress.SetBool("DeleteReleased", false);
            playDelete();
        }

        if (Input.GetKeyUp(KeyCode.Delete))
        {
            DeletePress.SetBool("DeletePressed", false);
            stopDelete();
        }

        if (Input.GetKeyDown(KeyCode.End))
        {
            EndPress.SetBool("EndReleased", false);
            playEnd();
        }

        if (Input.GetKeyUp(KeyCode.End))
        {
            EndPress.SetBool("EndPressed", false);
            stopEnd();
        }

        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            PageDownPress.SetBool("PageDownReleased", false);
            playPageDown();
        }

        if (Input.GetKeyUp(KeyCode.PageDown))
        {
            PageDownPress.SetBool("PageDownPressed", false);
            stopPageDown();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ArrowUpPress.SetBool("ArrowUpReleased", false);
            playArrowUp();
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            ArrowUpPress.SetBool("ArrowUpPressed", false);
            stopArrowUp();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ArrowDownPress.SetBool("ArrowDownReleased", false);
            playArrowDown();
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            ArrowDownPress.SetBool("ArrowDownPressed", false);
            stopArrowDown();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ArrowLeftPress.SetBool("ArrowLeftReleased", false);
            playArrowLeft();
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            ArrowLeftPress.SetBool("ArrowLeftPressed", false);
            stopArrowLeft();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ArrowRightPress.SetBool("ArrowRightReleased", false);
            playArrowRight();
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            ArrowRightPress.SetBool("ArrowRightPressed", false);
            stopArrowRight();
        }
    }
    void Update()
    {
        animations();
    }
}
