 
 u s i n g   U n i t y E n g i n e ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
  
 p u b l i c   c l a s s   A c c e l e r o m e t e r I n p u t   :   M o n o B e h a v i o u r   {  
 	 p r i v a t e   R i g i d b o d y   r b ;  
  
 	 v o i d   U p d a t e   ( )    
 	 {  
 	 	 t r a n s f o r m . T r a n s l a t e   ( ( I n p u t . a c c e l e r a t i o n . x ) / 2 ,   0 ,   ( - I n p u t . a c c e l e r a t i o n . z ) / 2 ) ;  
 	 }  
  
  
  
 	 v o i d   S t a r t   ( )    
 	 {  
 	 	 r b   =   G e t C o m p o n e n t < R i g i d b o d y >   ( ) ;  
 	 }  
  
  
 	 v o i d   F i x e d U p d a t e   ( )    
 	 {  
 	 	 f l o a t   m o v e H o r i z o n t a l   =   I n p u t . G e t A x i s   ( " H o r i z o n t a l " ) ;  
 	 	 f l o a t   m o v e V e r t i c a l   =   I n p u t . G e t A x i s   ( " V e r t i c a l " ) ;  
  
 	 	 V e c t o r 3   m o v e m e n t   =   n e w   V e c t o r 3   ( m o v e H o r i z o n t a l ,   0 . 0 f ,   m o v e V e r t i c a l ) ;  
  
 	 	 r b . A d d F o r c e   ( m o v e m e n t ) ;  
 	 }  
  
 }  
 