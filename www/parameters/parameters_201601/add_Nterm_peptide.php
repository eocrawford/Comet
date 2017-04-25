<?php include "head.php" ; ?>
<html>
<body>
<?php include "topmenu.php" ; ?>
<?php include "imgbar.php" ; ?>

<div id="page">
   <div id="content_full">
      <div class="post hr">

         <h2>Comet parameter: add_Nterm_peptide</h2>

         <ul>
         <li>Specify a static modification to the N-terminus of all peptides.
         <li>The specified mass is added to the unmodified N-terminal mass (mass of H or 1.007825).
         <li>The default value is "0.0" if this parameter is missing.
         </ul>

         <p>Example:
         <br><tt>add_Nterm_peptide = 14.01</tt>

      </div>
   </div>
   <div style="clear: both;">&nbsp;</div>
</div>

<?php include "footer.php" ; ?>
</html>
