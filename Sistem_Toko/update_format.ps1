$forms = @("EditKaryawan", "HapusKaryawan", "Restock", "RiwayatPenjualan", "StokGudang", "TambahKaryawan")
$baseDir = "C:\Users\Pongo\source\repos\Sistem_Toko\Sistem_Toko\View\AdminView"

$replacement = @"
            // 
            // Btn_Kembali
            // 
            Btn_Kembali.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_Kembali.BackColor = System.Drawing.Color.Transparent;
            Btn_Kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Btn_Kembali.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            Btn_Kembali.ForeColor = System.Drawing.Color.White;
            Btn_Kembali.Location = new System.Drawing.Point(5, 12);
            Btn_Kembali.Name = "Btn_Kembali";
            Btn_Kembali.Size = new System.Drawing.Size(40, 40);
            Btn_Kembali.TabIndex = 99;
            Btn_Kembali.UseVisualStyleBackColor = false;
            Btn_Kembali.Click += Btn_Kembali_Click;
"@

foreach ($form in $forms) {
    $file = "$baseDir\$form.Designer.cs"
    if (Test-Path $file) {
        $content = Get-Content $file -Raw
        $pattern = "(?s)            // \r?\n            // Btn_Kembali\r?\n            // .*?Btn_Kembali\.Click \+= Btn_Kembali_Click;"
        if ($content -match $pattern) {
            $newContent = $content -replace $pattern, $replacement
            Set-Content -Path $file -Value $newContent
            Write-Host "Updated $form.Designer.cs"
        } else {
            Write-Host "Could not find Btn_Kembali block in $form.Designer.cs"
        }
    }
}
