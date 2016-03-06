<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="transactionDatabase">
  <HTML>
    <BODY>
      <p>
        <H2>Transactions</H2> 
      </p>
    </BODY>
    <BODY>
           <TABLE BORDER="1">
        <TR>
          <TD>
            <b>№</b>
          </TD>
          <TD>
            <b>Тип</b>
          </TD>
         <TD>
            <b>Розмір</b>
          </TD>
          <TD>
            <b>Категорія</b>
          </TD>
          <TD>
            <b>Дата</b>
          </TD>
        </TR>
        
        <xsl:for-each select="//transaction">
          
			<tr>
				<TD>
					<p>
					  <xsl:value-of select="@id"/>
					</p>
				</TD>
				<TD>
					<p>
					  <xsl:value-of select="@type"/>
					</p>
				</TD>
            
				<TD>
					<p>
						<xsl:value-of select="."/>
					</p>
				</TD>
				<td>
					<p>
						<xsl:value-of select="@categoryId"/>
					</p>
				</td>
                <TD>
                  <p>
                    <xsl:value-of select="@date"/>
                  </p>
                </TD>
              </tr>
          </xsl:for-each>
        
      </TABLE>
	  
	  
	  
	  
	  
	  
	  <TABLE BORDER="2">
        <TR>
          <TD>
            <b>№</b>
          </TD>
          <TD>
            <b>Категорія</b>
          </TD>
         </TR>
        
        <xsl:for-each select="//category">
          
			<tr>
				<TD>
					<p>
					  <xsl:value-of select="@id"/>
					</p>
				</TD>
				<TD>
					<p>
					  <xsl:value-of select="."/>
					</p>
				</TD>
            
              </tr>
        </xsl:for-each>
        
      </TABLE>
	  
    </BODY>
  </HTML>
</xsl:template>
</xsl:stylesheet>
