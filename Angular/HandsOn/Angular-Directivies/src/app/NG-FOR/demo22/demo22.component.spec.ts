import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo22Component } from './demo22.component';

describe('Demo22Component', () => {
  let component: Demo22Component;
  let fixture: ComponentFixture<Demo22Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Demo22Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Demo22Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
