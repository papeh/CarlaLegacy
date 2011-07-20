<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/" mode="excl">
  <section1 id="sExcl">
	  <secTitle>Las exclamaciones y los saludos</secTitle>
	<p>
<xsl:text>Esta sección considera los varios tipos de elocuciones comunes que no sean oraciones completas. Los saludos, las interjecciones y las exclamaciones se cubren en turno.</xsl:text>
</p>
<section2 id="sExclGreet">
	<secTitle>Los saludos</secTitle>
	<p>
<xsl:text>Los saludos consisten típicamente en una palabra o una frase particular, o solamente o seguido por un nombre o una frase nominal que describe la persona o el animal que es saludado.
	Algunos son las oraciones completas o las preguntas completas, tales como </xsl:text>
<langData>
<xsl:attribute name="lang">
<xsl:text>lPAWSSKEnglish</xsl:text>
</xsl:attribute>¿Cómo está usted? </langData>
<xsl:text> y </xsl:text>
<langData>
<xsl:attribute name="lang">
<xsl:text>lPAWSSKEnglish</xsl:text>
</xsl:attribute>¡Tenga un buen día!</langData>
<xsl:text> cuáles no necesitan ser tratados por separado. Algunos ejemplos de saludos españoles son:
</xsl:text>
</p>
			<ol>
				<li>
					<xsl:text>¡Hola!</xsl:text>
				</li>
				<li>
					<xsl:text>¡Ciao!</xsl:text>
				</li>
				<li>
					<xsl:text>Hola, Juliana.</xsl:text>
				</li>
				<li>
					<xsl:text>Hasta Luego.</xsl:text>
				</li>
				<li>
					<xsl:text>Buen día, señor..</xsl:text>
				</li>
				<li>
					<xsl:text>Buena mañana, Roberto.</xsl:text>
				</li>
				<li>
					<xsl:text>Buenas tardes.</xsl:text>
				</li>
				<li>
					<xsl:text>Buenas noches.</xsl:text>
				</li>
				<li>
					<xsl:text>Buenas noches, bebé dulce.</xsl:text>
				</li>
			</ol>
	<p>
<xsl:text>Los ejemplos de saludos en </xsl:text>
<xsl:choose>
<xsl:when test="string-length(normalize-space(//language/langName)) &gt; 0">
<xsl:value-of select="normalize-space(//language/langName)" />
</xsl:when>
<xsl:otherwise>
<xsl:text>Vernacular</xsl:text>
</xsl:otherwise>
</xsl:choose>
<xsl:text> incluyen:</xsl:text>
</p>
			<example num="xExcl.ExclGreet.10">
<xsl:variable name="sExampleValue">
<xsl:value-of select="//excl/greetExample" />
</xsl:variable>
<xsl:variable name="iExampleLength" select="normalize-space(string-length(//excl/greetExample))" />
<xsl:choose>
<xsl:when test="$iExampleLength != 0 and $sExampleValue != ' '">
<xsl:call-template name="OutputInterlinearExamples">
<xsl:with-param name="sExamples">
<xsl:value-of select="//excl/greetExample" />
</xsl:with-param>
<xsl:with-param name="iLength">
<xsl:value-of select="string-length(//excl/greetExample)" />
</xsl:with-param>
<xsl:with-param name="sExNumber">xExcl.ExclGreet.10</xsl:with-param>
<xsl:with-param name="sLetterList">
<xsl:value-of select="$sMasterLetterList" />
</xsl:with-param>
</xsl:call-template>
</xsl:when>
<xsl:otherwise>
<listInterlinear>
<xsl:attribute name="letter">
<xsl:text>xExcl.ExclGreet.10.1</xsl:text>
</xsl:attribute>
<lineGroup>
<line>
<langData>
<xsl:attribute name="lang">lVernacular</xsl:attribute>INCOPORE UN EJEMPLO AQUÍ</langData>
</line>
<xsl:call-template name="DoWordGloss" />
<xsl:call-template name="DoMorphemeGloss" />
</lineGroup>
<xsl:call-template name="DoFree" />
</listInterlinear>
</xsl:otherwise>
</xsl:choose>
</example>
</section2>
<section2 id="sExclIntj">
	<secTitle>Las interjecciones</secTitle>
	<p>
<xsl:text>Las interjecciones consisten típicamente en una palabra o una frase particular que se utilicen solamente, generalmente con puntos de exclamación. Muchas de las palabras en interjecciones no se utilizan en ninguna otra situación, sin embargo los adjetivos regulares también se utilizan de esta manera. Algunos ejemplos de interjecciones en español son:
</xsl:text>
</p>
			<ol>
				<li>
					<xsl:text>¡Ay!</xsl:text>
				</li>
				<li>
					<xsl:text>¡Grueso!</xsl:text>
				</li>
				<li>
					<xsl:text>¡Fresco!</xsl:text>
				</li>
				<li>
					<xsl:text>¡Jehosaphat de salto!</xsl:text>
				</li>
				<li>
					<xsl:text>¡Grillo de Jimminy!</xsl:text>
				</li>
			</ol>
	<p>
<xsl:text>Los ejemplos de interjecciones en </xsl:text>
<xsl:choose>
<xsl:when test="string-length(normalize-space(//language/langName)) &gt; 0">
<xsl:value-of select="normalize-space(//language/langName)" />
</xsl:when>
<xsl:otherwise>
<xsl:text>Vernacular</xsl:text>
</xsl:otherwise>
</xsl:choose>
<xsl:text> incluyen:</xsl:text>
</p>
			<example num="xExcl.ExclIntj.10">
<xsl:variable name="sExampleValue">
<xsl:value-of select="//excl/intjExample" />
</xsl:variable>
<xsl:variable name="iExampleLength" select="normalize-space(string-length(//excl/intjExample))" />
<xsl:choose>
<xsl:when test="$iExampleLength != 0 and $sExampleValue != ' '">
<xsl:call-template name="OutputInterlinearExamples">
<xsl:with-param name="sExamples">
<xsl:value-of select="//excl/intjExample" />
</xsl:with-param>
<xsl:with-param name="iLength">
<xsl:value-of select="string-length(//excl/intjExample)" />
</xsl:with-param>
<xsl:with-param name="sExNumber">xExcl.ExclIntj.10</xsl:with-param>
<xsl:with-param name="sLetterList">
<xsl:value-of select="$sMasterLetterList" />
</xsl:with-param>
</xsl:call-template>
</xsl:when>
<xsl:otherwise>
<listInterlinear>
<xsl:attribute name="letter">
<xsl:text>xExcl.ExclIntj.10.1</xsl:text>
</xsl:attribute>
<lineGroup>
<line>
<langData>
<xsl:attribute name="lang">lVernacular</xsl:attribute>INCOPORE UN EJEMPLO AQUÍ</langData>
</line>
<xsl:call-template name="DoWordGloss" />
<xsl:call-template name="DoMorphemeGloss" />
</lineGroup>
<xsl:call-template name="DoFree" />
</listInterlinear>
</xsl:otherwise>
</xsl:choose>
</example>
	<p>
<xsl:text>Respuestas de "Sí" y "No" a las preguntas sea similar a las interjecciones.  </xsl:text>
<xsl:choose>
<xsl:when test="string-length(normalize-space(//language/langName)) &gt; 0">
<xsl:value-of select="normalize-space(//language/langName)" />
</xsl:when>
<xsl:otherwise>
<xsl:text>Vernacular</xsl:text>
</xsl:otherwise>
</xsl:choose>
<xsl:text> utiliza las palabras siguientes para expresar estas respuestas: </xsl:text>
</p>
<example num="xExcl.ExclIntj.14">
<table border="1">
					<tr>
						<th>
							<xsl:choose>
<xsl:when test="string-length(normalize-space(//language/langName)) &gt; 0">
<xsl:value-of select="normalize-space(//language/langName)" />
</xsl:when>
<xsl:otherwise>
<xsl:text>Vernacular</xsl:text>
</xsl:otherwise>
</xsl:choose>
						</th>
						<th>Significado</th>
					</tr>
					<xsl:variable name="sExampleValue0">
<xsl:value-of select="translate(string(//excl/yesExample),'.','')" />
</xsl:variable>
<xsl:variable name="iExampleLength0" select="string-length($sExampleValue0)" />
<xsl:choose>
<xsl:when test="$iExampleLength0 != 0 and $sExampleValue0 != ' '">
<xsl:variable name="sCalculatedRows">
<xsl:call-template name="CalculateRows">
<xsl:with-param name="sExamples">
<xsl:value-of select="$sExampleValue0" />
</xsl:with-param>
</xsl:call-template>
</xsl:variable>
<xsl:call-template name="OutputColExamples">
<xsl:with-param name="sExamples">
<xsl:value-of select="$sExampleValue0" />
</xsl:with-param>
<xsl:with-param name="iLength">
<xsl:value-of select="$iExampleLength0" />
</xsl:with-param>
<xsl:with-param name="columnsBefore" />
<xsl:with-param name="columnsAfter">
<td align="left" rowspan="1">
							<xsl:text>sí</xsl:text>
						</td>
</xsl:with-param>
<xsl:with-param name="bHandleRowSpans" select="'Y'" />
<xsl:with-param name="iRowsToSpan" select="string-length($sCalculatedRows)" />
</xsl:call-template>
</xsl:when>
<xsl:otherwise>
<tr>
<td>
<langData>
<xsl:attribute name="lang">lVernacular</xsl:attribute>INCOPORE UN EJEMPLO AQUÍ</langData>
</td>
<td align="left" rowspan="1">
							<xsl:text>sí</xsl:text>
						</td>
</tr>
</xsl:otherwise>
</xsl:choose>
					<xsl:variable name="sExampleValue1">
<xsl:value-of select="translate(string(//excl/noExample),'.','')" />
</xsl:variable>
<xsl:variable name="iExampleLength1" select="string-length($sExampleValue1)" />
<xsl:choose>
<xsl:when test="$iExampleLength1 != 0 and $sExampleValue1 != ' '">
<xsl:variable name="sCalculatedRows">
<xsl:call-template name="CalculateRows">
<xsl:with-param name="sExamples">
<xsl:value-of select="$sExampleValue1" />
</xsl:with-param>
</xsl:call-template>
</xsl:variable>
<xsl:call-template name="OutputColExamples">
<xsl:with-param name="sExamples">
<xsl:value-of select="$sExampleValue1" />
</xsl:with-param>
<xsl:with-param name="iLength">
<xsl:value-of select="$iExampleLength1" />
</xsl:with-param>
<xsl:with-param name="columnsBefore" />
<xsl:with-param name="columnsAfter">
<td align="left" rowspan="1">
							<xsl:text>no</xsl:text>
						</td>
</xsl:with-param>
<xsl:with-param name="bHandleRowSpans" select="'Y'" />
<xsl:with-param name="iRowsToSpan" select="string-length($sCalculatedRows)" />
</xsl:call-template>
</xsl:when>
<xsl:otherwise>
<tr>
<td>
<langData>
<xsl:attribute name="lang">lVernacular</xsl:attribute>INCOPORE UN EJEMPLO AQUÍ</langData>
</td>
<td align="left" rowspan="1">
							<xsl:text>no</xsl:text>
						</td>
</tr>
</xsl:otherwise>
</xsl:choose>
</table>
</example>
</section2>
<section2 id="sExclExcl">
	<secTitle>Las exclamaciones</secTitle>
	<p>
<xsl:text>Las exclamaciones consisten típicamente en una palabra particular, tal como </xsl:text>
<langData>
<xsl:attribute name="lang">
<xsl:text>lPAWSSKEnglish</xsl:text>
</xsl:attribute>cómo</langData>
<xsl:text> en español, seguida por una frase del adjetivo y puntuada generalmente con puntos de exclamación. Los ejemplos españoles incluyen:</xsl:text>
</p>
<ol>
	<li>
<xsl:text>¡Cómo es tremendo para usted!</xsl:text>
</li>
	<li>
<xsl:text>¡Cómo es agradable!</xsl:text>
</li>
	<li>
<xsl:text>¡Cómo es maravilloso que su familia podría venir!</xsl:text>
</li>
</ol>
	<p>
<xsl:text>Los ejemplos de exclamaciones en </xsl:text>
<xsl:choose>
<xsl:when test="string-length(normalize-space(//language/langName)) &gt; 0">
<xsl:value-of select="normalize-space(//language/langName)" />
</xsl:when>
<xsl:otherwise>
<xsl:text>Vernacular</xsl:text>
</xsl:otherwise>
</xsl:choose>
<xsl:text> incluyen:</xsl:text>
</p>
			<example num="xExcl.ExclExcl.10">
<xsl:variable name="sExampleValue">
<xsl:value-of select="//excl/exclExample" />
</xsl:variable>
<xsl:variable name="iExampleLength" select="normalize-space(string-length(//excl/exclExample))" />
<xsl:choose>
<xsl:when test="$iExampleLength != 0 and $sExampleValue != ' '">
<xsl:call-template name="OutputInterlinearExamples">
<xsl:with-param name="sExamples">
<xsl:value-of select="//excl/exclExample" />
</xsl:with-param>
<xsl:with-param name="iLength">
<xsl:value-of select="string-length(//excl/exclExample)" />
</xsl:with-param>
<xsl:with-param name="sExNumber">xExcl.ExclExcl.10</xsl:with-param>
<xsl:with-param name="sLetterList">
<xsl:value-of select="$sMasterLetterList" />
</xsl:with-param>
</xsl:call-template>
</xsl:when>
<xsl:otherwise>
<listInterlinear>
<xsl:attribute name="letter">
<xsl:text>xExcl.ExclExcl.10.1</xsl:text>
</xsl:attribute>
<lineGroup>
<line>
<langData>
<xsl:attribute name="lang">lVernacular</xsl:attribute>INCOPORE UN EJEMPLO AQUÍ</langData>
</line>
<xsl:call-template name="DoWordGloss" />
<xsl:call-template name="DoMorphemeGloss" />
</lineGroup>
<xsl:call-template name="DoFree" />
</listInterlinear>
</xsl:otherwise>
</xsl:choose>
</example>
	<xsl:if test="normalize-space(//excl/@exclM)='no'">
<p>
<xsl:choose>
<xsl:when test="string-length(normalize-space(//language/langName)) &gt; 0">
<xsl:value-of select="normalize-space(//language/langName)" />
</xsl:when>
<xsl:otherwise>
<xsl:text>Vernacular</xsl:text>
</xsl:otherwise>
</xsl:choose>
<xsl:text> no tiene una palabra especial que marque exclamaciones de este tipo, así que no son diferentes que las interjecciones que consisten en adjetivos en la sección anterior.</xsl:text>
</p>
</xsl:if>
	<xsl:if test="normalize-space(//excl/@exclM)='yes'">
<p>
<xsl:choose>
<xsl:when test="string-length(normalize-space(//language/langName)) &gt; 0">
<xsl:value-of select="normalize-space(//language/langName)" />
</xsl:when>
<xsl:otherwise>
<xsl:text>Vernacular</xsl:text>
</xsl:otherwise>
</xsl:choose>
<xsl:text> tiene una o más palabras especiales que señalen una exclamación cuáles ocurren </xsl:text>
<xsl:choose>
<xsl:when test="//excl/@exclMPos='before'">antes</xsl:when>
		<xsl:when test="//excl/@exclMPos='after'">después</xsl:when>
		<xsl:when test="//excl/@exclMPos='either'">de cualquier lado</xsl:when>
		<xsl:when test="//excl/@exclMPos='both'">en ambos lados</xsl:when>
	</xsl:choose>
<xsl:text> de la frase del adjetivo. Estas palabras del marcador de la exclamación son:</xsl:text>
</p>
</xsl:if>
<xsl:if test="normalize-space(//excl/@exclM)='yes'">
<example num="xExcl.ExclExcl.16">
<table border="0">
<tr>
	<th>Marcadores de la exclamación</th>
	<th>Significado</th>
</tr>
	<xsl:variable name="sExampleValue0">
<xsl:value-of select="translate(string(//excl/exclMExample),'.','')" />
</xsl:variable>
<xsl:variable name="iExampleLength0" select="string-length($sExampleValue0)" />
<xsl:choose>
<xsl:when test="$iExampleLength0 != 0 and $sExampleValue0 != ' '">
<xsl:variable name="sCalculatedRows">
<xsl:call-template name="CalculateRows">
<xsl:with-param name="sExamples">
<xsl:value-of select="$sExampleValue0" />
</xsl:with-param>
</xsl:call-template>
</xsl:variable>
<xsl:call-template name="OutputColExamples">
<xsl:with-param name="sExamples">
<xsl:value-of select="$sExampleValue0" />
</xsl:with-param>
<xsl:with-param name="iLength">
<xsl:value-of select="$iExampleLength0" />
</xsl:with-param>
<xsl:with-param name="columnsBefore" />
<xsl:with-param name="columnsAfter">
<td align="left">
<gloss>
<xsl:attribute name="lang">lGloss</xsl:attribute>
<xsl:text>PONE EL SIGNIFICADO</xsl:text>
</gloss>
</td>
</xsl:with-param>
<xsl:with-param name="bHandleRowSpans" select="'Y'" />
<xsl:with-param name="iRowsToSpan" select="string-length($sCalculatedRows)" />
</xsl:call-template>
</xsl:when>
<xsl:otherwise>
<tr>
<td>
<langData>
<xsl:attribute name="lang">lVernacular</xsl:attribute>INCOPORE UN EJEMPLO AQUÍ</langData>
</td>
<td align="left">
<gloss>
<xsl:attribute name="lang">lGloss</xsl:attribute>
<xsl:text>PONE EL SIGNIFICADO</xsl:text>
</gloss>
</td>
</tr>
</xsl:otherwise>
</xsl:choose>
</table>
</example>
</xsl:if>
	<xsl:if test="normalize-space(//excl/@exclM)='yes' and normalize-space(//excl/@exclMPos)='either' and normalize-space(//excl/@exclMEither)='no' or normalize-space(//excl/@exclM)='yes' and normalize-space(//excl/@exclMPos)='both' and normalize-space(//excl/@exclMEither)='no'">
<p>
<xsl:text>Hay restricciones en cuanto a las cuales palabras que pueden ocurrir en cada lado de la frase del adjetivo. </xsl:text>
</p>
</xsl:if>
	<xsl:if test="normalize-space(//excl/@exclM)='yes' and normalize-space(//excl/@exclMPos)='either' and normalize-space(//excl/@exclMEither)='yes' or normalize-space(//excl/@exclM)='yes' and normalize-space(//excl/@exclMPos)='both' and normalize-space(//excl/@exclMEither)='yes'">
<p>
<xsl:text>Todas las palabras pueden ocurrir de cualquier lado de la frase del adjetivo.</xsl:text>
</p>
</xsl:if>
</section2>
  </section1>
































</xsl:template>
</xsl:stylesheet>