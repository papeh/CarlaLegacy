// Last revison: 4/19/2002 1:24:12 PM [mr]

/////////////////////////////////////////////////////////////////////////////

#if _MSC_VER >= 1000
#pragma once
#endif // _MSC_VER >= 1000
// TestEdit.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CTestEdit window

class CTestEdit : public CRichEditCtrl
{
// Construction
public:
	CTestEdit();


// Attributes
public:
	struct SymbolColor {
		COLORREF clrColor;
		BOOL bBold;
		BOOL bItalic;
		BOOL bUnderline;
		BOOL bStrikeout;
	};


	SymbolColor m_colorDefault,m_colorOPErators,m_colorForOPErators,
		m_colorLOCations,m_colorKEYWords,m_colorCONNectors,
		m_colorTYPes,m_colorNBR,m_colorIdentifiers,m_colorError,
		m_colorCOMments;


	CString m_strOPErators,m_strFOROPerators,m_strLOCations,m_strKEYWords,
			m_strKEYWords_Act,m_strCONNectors,m_strTYPes,m_strNBR;

	CString m_strOPEratorsLower,m_strFOROPeratorsLower,m_strLOCationsLower,
			m_strKEYWordsLower,m_strKEYWords_ActLower,m_strCONNectorsLower,
			m_strTYPesLower,m_strNBRLower;

// Operations
public:
	void Initialize();
	void FormatAll();
	void SetFontSize( LPCTSTR lpzFontSize);
	void SetChangeCase(BOOL bChange);
	void SetSLComment( TCHAR chComment );
	void SetSLComment(LPCTSTR lpszComment);
	void SetStringQuotes(LPCTSTR lpszStrQ);
	void AddKeywords( LPCTSTR lpszKwd,CString &str, CString &strLower );
	void setColor( SymbolColor &color,COLORREF clr,BOOL bBold,BOOL bItalic,BOOL bUnderline,BOOL bStrikeout);
	void setDefaultCharFormat();
	void setSelectionCharFormat( );
	void setWordWrap( BOOL bFlag );
	void setBackgroundColor( BOOL bUseSystemColor );
	void readRegistry( LPCTSTR lpzSection );


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTestEdit)
	//}}AFX_VIRTUAL

// Implementation
public:
	virtual ~CTestEdit();

	// Generated message map functions
protected:





	BOOL IsStringQuote(TCHAR ch);
	int searching( LPCTSTR lpszSymbol,CString &strGroup );
	void SetFormatRange(int nStart, int nEnd, BOOL bBold,
						BOOL bItalic,BOOL bUnderline,
						BOOL bStrikeout,COLORREF clr);
	void FormatTextRange(int nStart, int nEnd);
	void FormatTextLines(int nStart, int nEnd);
	void ChangeCase(int nStart, int nEnd, LPCTSTR lpszStr);



	enum ChangeType {ctUndo, ctUnknown, ctReplSel, ctDelete, ctBack, ctCut, ctPaste, ctMove, ctSpace};

	COLORREF clrDefaultColor,m_clrBackgoundColor;

	BOOL m_bInForcedChange,m_bChangeCase;

	TCHAR m_chComment;

	CString m_strLastKeyWord,m_lpzFontSize,m_strPOSition,
		m_strTYPe,m_strTRM,m_strACTions,m_strComment,
		m_strStringQuotes,m_strPOSitionLower,m_strTYPeLower,
		m_strTRMLower;


	ChangeType m_changeType;
	CHARRANGE m_crOldSel;

	//{{AFX_MSG(CTestEdit)
	afx_msg void OnChange();
	afx_msg UINT OnGetDlgCode();
	afx_msg void OnChar(UINT nChar, UINT nRepCnt, UINT nFlags);

	//}}AFX_MSG
	afx_msg LRESULT OnSetText(WPARAM wParam, LPARAM lParam);
	afx_msg void OnProtected(NMHDR*, LRESULT* pResult);
	afx_msg void OnSelChange(NMHDR*, LRESULT* pResult);
	DECLARE_MESSAGE_MAP()

	private:
		BOOL m_bOpenQuote;
		BOOL m_bUseBackgroundSystemColor;



};

/////////////////////////////////////////////////////////////////////////////