$files = Get-ChildItem -Path "C:\Users\Pongo\source\repos\Sistem_Toko\Sistem_Toko\View" -Recurse -Filter *.Designer.cs
foreach ($file in $files) {
    $content = Get-Content $file.FullName -Raw
    
    # Skip if already injected
    if ($content -match "INJECTED_MANUAL_UI") { continue }
    
    # Find all button and panel names
    $buttons = [regex]::Matches($content, 'private\s+(?:System\.Windows\.Forms\.)?Button\s+(\w+);') | ForEach-Object { $_.Groups[1].Value }
    $panels = [regex]::Matches($content, 'private\s+(?:System\.Windows\.Forms\.)?Panel\s+(\w+);') | ForEach-Object { $_.Groups[1].Value }
    
    $injections = "`r`n            // INJECTED_MANUAL_UI`r`n"
    $injections += "            this.BackColor = System.Drawing.Color.WhiteSmoke;`r`n"
    $injections += "            this.Font = new System.Drawing.Font(`"Segoe UI`", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);`r`n"
    
    foreach ($btn in $buttons) {
        $injections += "            this.$btn.BackColor = System.Drawing.Color.SeaGreen;`r`n"
        $injections += "            this.$btn.ForeColor = System.Drawing.Color.White;`r`n"
        $injections += "            this.$btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;`r`n"
        $injections += "            this.$btn.Cursor = System.Windows.Forms.Cursors.Hand;`r`n"
        $injections += "            this.$btn.Font = new System.Drawing.Font(`"Segoe UI`", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);`r`n"
    }
    
    foreach ($pnl in $panels) {
        $injections += "            this.$pnl.BackColor = System.Drawing.Color.MediumSeaGreen;`r`n"
    }
    
    # Find insertion point: right before this.ResumeLayout
    $newContent = $content -replace "(?s)(\s+this\.ResumeLayout)", "$injections`$1"
    
    Set-Content $file.FullName $newContent
}
