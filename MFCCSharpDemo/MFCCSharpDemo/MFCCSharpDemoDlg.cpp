/* ** ** ** ** ** ** ** ** ** ** **

MFC Components and Controls demo

Copyright 2018 Giuseppe Pischedda
All rights reserved

https://www.software-on-demand-ita.com

This project is released under MIT license

** ** ** ** ** ** ** ** ** ** ** **/





// MFCCSharpDemoDlg.cpp : implementation file
//

#include "stdafx.h"
#include "MFCCSharpDemo.h"
#include "MFCCSharpDemoDlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_ABOUTBOX };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(IDD_ABOUTBOX)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CMFCCSharpDemoDlg dialog



CMFCCSharpDemoDlg::CMFCCSharpDemoDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_MFCCSHARPDEMO_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CMFCCSharpDemoDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);

	DDX_ManagedControl(pDX, IDC_CFCOMPONENT, m_cfComponent);
	DDX_ManagedControl(pDX, IDC_TXT_COGNOME, m_txtCognome);
	DDX_ManagedControl(pDX, IDC_TXT_NOME, m_txtNome);
	DDX_ManagedControl(pDX, IDC_CTRL_CMB_SEX, m_cmbSesso);
	DDX_ManagedControl(pDX, IDC_NASCITA_DTPICKER, m_dtNascitaPicker);
	DDX_ManagedControl(pDX, IDC_CTRL_CMB_REGIONI, m_cmbRegioni);
	DDX_ManagedControl(pDX, IDC_CTRL_CMB_PROVINCE, m_cmbProvince);
	DDX_ManagedControl(pDX, IDC_CTRL_CMB_COMUNI, m_cmbComuni);
	DDX_Control(pDX, IDC_EDIT1, m_editCtrl);
}

BEGIN_MESSAGE_MAP(CMFCCSharpDemoDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON1, &CMFCCSharpDemoDlg::OnBnClickedButtonCalculate)
END_MESSAGE_MAP()


// CMFCCSharpDemoDlg message handlers

BOOL CMFCCSharpDemoDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != nullptr)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	m_cfComponent.GetControl()->CFComponent->CognomeTextBox = m_txtCognome.GetControl()->CognomeTextBox;
	m_cfComponent.GetControl()->CFComponent->NomeTextBox = m_txtNome.GetControl()->NomeTextBox;
	m_cfComponent.GetControl()->CFComponent->SessoDropDownList = m_cmbSesso.GetControl()->SessoDropDownList;
	m_cfComponent.GetControl()->CFComponent->DataNascitaPicker = m_dtNascitaPicker.GetControl()->DataNascitaPicker;
	m_cfComponent.GetControl()->CFComponent->RegioniDropDownList = m_cmbRegioni.GetControl()->RegioniDropDownList;
	m_cfComponent.GetControl()->CFComponent->ProvinceDropDownList = m_cmbProvince.GetControl()->ProvinceDropDownList;
	m_cfComponent.GetControl()->CFComponent->ComuniDropDownList = m_cmbComuni.GetControl()->ComuniDropDownList;


	m_cmbRegioni.GetControl()->RegioniDropDownList->RegioneSelectedValueChanged += MAKE_DELEGATE(CFComponentN18::RegioniDropDownList::RegioniDropDownList::RegioneSelectedEventHandler, OnRegioniSelectedValueChanged);
	m_cmbProvince.GetControl()->ProvinceDropDownList->ProvinciaSelectedValueChanged += MAKE_DELEGATE(CFComponentN18::ProvinceDropDownList::ProvinceDropDownList::ProvinciaSelectedEventHandler, OnProvinceSelectedValueChanged);

	

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CMFCCSharpDemoDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CMFCCSharpDemoDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CMFCCSharpDemoDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


void CMFCCSharpDemoDlg::OnRegioniSelectedValueChanged(System::Object ^ obj, CFComponentN18::RegioniDropDownList::RegioniDropDownList::RegioneSelectedEventArgs ^ e)
{
	m_cmbProvince.GetControl()->ProvinceDropDownList->UpdateData(e->ItemValue);
}


void CMFCCSharpDemoDlg::OnProvinceSelectedValueChanged(System::Object ^ obj, CFComponentN18::ProvinceDropDownList::ProvinceDropDownList::ProvinciaSelectedEventArgs ^ e)
{
	m_cmbComuni.GetControl()->ComuniDropDownList->UpdateData(e->ItemValue);
}




void CMFCCSharpDemoDlg::OnBnClickedButtonCalculate()
{
	// TODO: Add your control notification handler code here

	CString szCFCode = m_cfComponent.GetControl()->CFComponent->GetCodiceFiscale;
	
	m_editCtrl.SetWindowTextW(szCFCode);
}
