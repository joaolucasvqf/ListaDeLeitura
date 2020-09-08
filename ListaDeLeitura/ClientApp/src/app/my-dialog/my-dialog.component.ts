import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from "@angular/material/dialog";

@Component({
  selector: 'app-my-dialog',
  templateUrl: './my-dialog.component.html',
  styleUrls: ['./my-dialog.component.css']
})
export class MyDialogComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<MyDialogComponent>) { }

  confirmar() {
    this.dialogRef.close(true);
  }

  recusar() {
    this.dialogRef.close(false);
  }

  ngOnInit() {
  }

}
