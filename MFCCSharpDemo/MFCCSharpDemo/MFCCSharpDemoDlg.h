/* ** ** ** ** ** ** ** ** ** ** **

MFC Components and Controls demo

Copyright 2018 Giuseppe Pischedda
All rights reserved

https://www.software-on-demand-ita.com

This project is released under MIT license

** ** ** ** ** ** ** ** ** ** ** **/



// MFCCSharpDemoDlg.h : header file
//

#pragma once


// CMFCCSharpDemoDlg dialog
class CMFCCSharpDemoDlg : public CDialogEx
{
// Construction
public:
	CMFCCSharpDemoDlg(CWnd* pParent = nullptr);	// standard constructor

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_MFCCSHARPDEMO_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()

private:
	
	CWinFormsControl<ProxyClassLibrary::CfComponent> m_cfComponent;
	CWinFormsControl<ProxyClassLibrary::TxtCognome> m_txtCognome;
	CWinFormsControl<ProxyClassLibrary::TxtNome> m_txtNome;
	CWinFormsControl<ProxyClassLibrary::CmbSesso> m_cmbSesso;
	CWinFormsControl<ProxyClassLibrary::DtNascitaPicker> m_dtNascitaPicker;
	CWinFormsControl<ProxyClassLibrary::CmbRegioni> m_cmbRegioni;
	CWinFormsControl<ProxyClassLibrary::CmbProvince> m_cmbProvince;
	CWinFormsControl<ProxyClassLibrary::CmbComuni> m_cmbComuni;

	


public:

	// delegate map  
	BEGIN_DELEGATE_MAP(CMFCCSharpDemoDlg)

		EVENT_DELEGATE_ENTRY(OnRegioniSelectedValueChanged, System::Object^,
			CFComponentN18::RegioniDropDownList::RegioniDropDownList::RegioneSelectedEventArgs ^)

		EVENT_DELEGATE_ENTRY(OnProvinceSelectedValueChanged, System::Object^,
			CFComponentN18::ProvinceDropDownList::ProvinceDropDownList::ProvinciaSelectedEventArgs ^)

	END_DELEGATE_MAP()


	void OnRegioniSelectedValueChanged(System::Object ^obj,
		CFComponentN18::RegioniDropDownList::RegioniDropDownList::RegioneSelectedEventArgs ^e);

	void OnProvinceSelectedValueChanged(System::Object ^obj,
		CFComponentN18::ProvinceDropDownList::ProvinceDropDownList::ProvinciaSelectedEventArgs ^e);


	afx_msg void OnBnClickedButtonCalculate();
	CEdit m_editCtrl;
};
